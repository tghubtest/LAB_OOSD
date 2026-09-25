using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Data
{
    public static class Db
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["QuanLyKhachSanDB"].ConnectionString;

        public static SqlConnection OpenConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int Execute(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteScalar();
            }
        }
    }

    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }
        public static KetQuaXuLy Ok(string msg) => new KetQuaXuLy { ThanhCong = true, ThongBao = msg };
        public static KetQuaXuLy Fail(string msg) => new KetQuaXuLy { ThanhCong = false, ThongBao = msg };
    }

    public class PhongDatItem
    {
        public string SoPhong { get; set; }
        public int SoNguoi { get; set; }
        public decimal DonGiaNgay { get; set; }
    }

    public class DenBuItem
    {
        public string MaTienNghi { get; set; }
        public string TenLoaiTN { get; set; }
        public string MucDoThietHai { get; set; }
        public decimal SoTien { get; set; }
    }
}