using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DichVuService
    {
        public KetQuaXuLy GhiNhan(string soPhieuDat, string soPhong, DateTime ngay, string maNV, string maDV, int soLuong)
        {
            if (soLuong <= 0) return KetQuaXuLy.Fail("Số lượng phải lớn hơn 0.");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    var g = new SqlCommand("SELECT DonGia FROM DichVu WHERE MaDV=@d", cn, tx);
                    g.Parameters.AddWithValue("@d", maDV);
                    decimal gia = Convert.ToDecimal(g.ExecuteScalar());

                    // Tìm hoặc tạo phiếu SDDV cho phòng trong ngày
                    var f = new SqlCommand("SELECT SoPhieuSDDV FROM PhieuSuDungDV WHERE SoPhieuDat=@s AND SoPhong=@p AND NgaySuDung=@n", cn, tx);
                    f.Parameters.AddWithValue("@s", soPhieuDat); f.Parameters.AddWithValue("@p", soPhong); f.Parameters.AddWithValue("@n", ngay.Date);
                    string soSD = Convert.ToString(f.ExecuteScalar());

                    if (string.IsNullOrWhiteSpace(soSD))
                    {
                        soSD = "SD" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                        var h = new SqlCommand("INSERT INTO PhieuSuDungDV VALUES(@so,@s,@p,@n,@nv)", cn, tx);
                        h.Parameters.AddWithValue("@so", soSD); h.Parameters.AddWithValue("@s", soPhieuDat); h.Parameters.AddWithValue("@p", soPhong);
                        h.Parameters.AddWithValue("@n", ngay.Date); h.Parameters.AddWithValue("@nv", maNV);
                        h.ExecuteNonQuery();
                    }

                    // Quy tắc BR07: Cùng DV trong ngày thì CỘNG DỒN SỐ LƯỢNG
                    var chk = new SqlCommand("SELECT COUNT(*) FROM ChiTietPhieuSuDungDV WHERE SoPhieuSDDV=@so AND MaDV=@d", cn, tx);
                    chk.Parameters.AddWithValue("@so", soSD); chk.Parameters.AddWithValue("@d", maDV);

                    if (Convert.ToInt32(chk.ExecuteScalar()) > 0)
                    {
                        var u = new SqlCommand("UPDATE ChiTietPhieuSuDungDV SET SoLuong=SoLuong+@sl WHERE SoPhieuSDDV=@so AND MaDV=@d", cn, tx);
                        u.Parameters.AddWithValue("@sl", soLuong); u.Parameters.AddWithValue("@so", soSD); u.Parameters.AddWithValue("@d", maDV);
                        u.ExecuteNonQuery();
                    }
                    else
                    {
                        var i = new SqlCommand("INSERT INTO ChiTietPhieuSuDungDV VALUES(@so,@d,@sl,@g)", cn, tx);
                        i.Parameters.AddWithValue("@so", soSD); i.Parameters.AddWithValue("@d", maDV); i.Parameters.AddWithValue("@sl", soLuong); i.Parameters.AddWithValue("@g", gia);
                        i.ExecuteNonQuery();
                    }
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã ghi nhận dịch vụ (đã cộng dồn nếu cùng ngày).");
                }
                catch (Exception ex) { tx.Rollback(); return KetQuaXuLy.Fail(ex.Message); }
            }
        }
    }
}