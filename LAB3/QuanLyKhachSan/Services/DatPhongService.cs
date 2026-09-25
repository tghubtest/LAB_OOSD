using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DatPhongService
    {
        public DataTable LayKhach() => Db.Query("SELECT * FROM KhachHang ORDER BY HoTen");
        public DataTable LayPhong() => Db.Query("SELECT p.*, k.TenKhuVuc FROM Phong p JOIN KhuVuc k ON p.MaKhuVuc=k.MaKhuVuc ORDER BY p.SoPhong");
        public DataTable LayPhieuDat() => Db.Query("SELECT d.*, k.HoTen FROM PhieuDatPhong d JOIN KhachHang k ON d.MaKhach=k.MaKhach ORDER BY d.NgayLap DESC");
        public DataTable LayChiTiet(string so) => Db.Query("SELECT c.*, p.SoNguoiToiDa, p.DonGiaNgay FROM ChiTietDatPhong c JOIN Phong p ON c.SoPhong=p.SoPhong WHERE c.SoPhieuDat=@s", new SqlParameter("@s", so));
        public DataTable LayNguoiLuuTru(string so) => Db.Query("SELECT * FROM NguoiLuuTru WHERE SoPhieuDat=@s ORDER BY SoPhong, MaNguoiLT", new SqlParameter("@s", so));

        public KetQuaXuLy ThemKhach(string ma, string ten, string cmnd, string qt, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(cmnd))
                return KetQuaXuLy.Fail("Thông tin khách chưa đầy đủ.");
            try
            {
                Db.Execute("INSERT INTO KhachHang VALUES(@m,@t,@c,@q,@s)",
                    new SqlParameter("@m", ma), new SqlParameter("@t", ten),
                    new SqlParameter("@c", cmnd), new SqlParameter("@q", qt), new SqlParameter("@s", sdt));
                return KetQuaXuLy.Ok("Đã lưu khách hàng.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        private bool PhongTrungLich(SqlConnection cn, SqlTransaction tx, string phong, DateTime nhan, DateTime tra)
        {
            var cmd = new SqlCommand(@"SELECT COUNT(*) FROM ChiTietDatPhong c 
                                       JOIN PhieuDatPhong d ON c.SoPhieuDat=d.SoPhieuDat 
                                       WHERE c.SoPhong=@p AND d.TrangThai IN (N'Đã đặt', N'Đang ở') 
                                       AND @nhan <= d.NgayTraDuKien AND @tra >= d.NgayNhan", cn, tx);
            cmd.Parameters.AddWithValue("@p", phong);
            cmd.Parameters.AddWithValue("@nhan", nhan.Date);
            cmd.Parameters.AddWithValue("@tra", tra.Date);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public KetQuaXuLy TaoDatPhong(string so, string maKhach, string maNV, DateTime ngayLap, DateTime nhan, DateTime tra, decimal coc, string kenh, List<PhongDatItem> ds)
        {
            if (string.IsNullOrWhiteSpace(so) || string.IsNullOrWhiteSpace(maKhach) || ds == null || ds.Count == 0)
                return KetQuaXuLy.Fail("Phiếu đặt chưa đủ thông tin.");
            if (tra.Date < nhan.Date) return KetQuaXuLy.Fail("Ngày trả không hợp lệ.");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    foreach (var x in ds)
                    {
                        var q = new SqlCommand("SELECT SoNguoiToiDa FROM Phong WHERE SoPhong=@p", cn, tx);
                        q.Parameters.AddWithValue("@p", x.SoPhong);
                        var max = Convert.ToInt32(q.ExecuteScalar());

                        // Kiểm tra Sức Chứa
                        if (x.SoNguoi <= 0 || x.SoNguoi > max)
                            return KetQuaXuLy.Fail($"Phòng {x.SoPhong} vượt sức chứa tối đa ({max} người).");

                        // Kiểm tra Trùng Lịch
                        if (PhongTrungLich(cn, tx, x.SoPhong, nhan, tra))
                            return KetQuaXuLy.Fail($"Phòng {x.SoPhong} bị trùng lịch đặt trong khoảng thời gian này.");
                    }

                    var h = new SqlCommand("INSERT INTO PhieuDatPhong(SoPhieuDat, MaKhach, MaNVLeTan, NgayLap, NgayNhan, NgayTraDuKien, TienCoc, KenhDat, TrangThai) VALUES(@s,@k,@nv,@lap,@nhan,@tra,@c,@kenh,N'Đã đặt')", cn, tx);
                    h.Parameters.AddWithValue("@s", so); h.Parameters.AddWithValue("@k", maKhach); h.Parameters.AddWithValue("@nv", maNV);
                    h.Parameters.AddWithValue("@lap", ngayLap); h.Parameters.AddWithValue("@nhan", nhan.Date); h.Parameters.AddWithValue("@tra", tra.Date);
                    h.Parameters.AddWithValue("@c", coc); h.Parameters.AddWithValue("@kenh", kenh);
                    h.ExecuteNonQuery();

                    foreach (var x in ds)
                    {
                        var c = new SqlCommand("INSERT INTO ChiTietDatPhong VALUES(@s,@p,@n)", cn, tx);
                        c.Parameters.AddWithValue("@s", so); c.Parameters.AddWithValue("@p", x.SoPhong); c.Parameters.AddWithValue("@n", x.SoNguoi);
                        c.ExecuteNonQuery();

                        var u = new SqlCommand("UPDATE Phong SET TrangThai=N'Đã đặt' WHERE SoPhong=@p", cn, tx);
                        u.Parameters.AddWithValue("@p", x.SoPhong);
                        u.ExecuteNonQuery();
                    }
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập phiếu đặt phòng thành công.");
                }
                catch (Exception ex) { tx.Rollback(); return KetQuaXuLy.Fail(ex.Message); }
            }
        }
    }
}