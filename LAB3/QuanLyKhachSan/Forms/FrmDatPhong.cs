using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            KhoiTaoCacBang();
            NapDuLieuMau();
        }

        private void KhoiTaoCacBang()
        {
            // 1. Bảng phòng (bên trái)
            dgvPhong.Columns.Clear();
            dgvPhong.Columns.Add("Phong", "Phòng");
            dgvPhong.Columns.Add("Khu", "Khu");
            dgvPhong.Columns.Add("SucChua", "Sức chứa");
            dgvPhong.Columns.Add("DonGia", "Đơn giá");

            // 2. Bảng phòng chọn (bên phải)
            dgvChon.Columns.Clear();
            dgvChon.Columns.Add("PhongChon", "Phòng chọn");
            dgvChon.Columns.Add("SoNguoi", "Số người");
            dgvChon.Columns.Add("DonGiaNgay", "Đơn giá/ngày");

            // 3. Bảng phiếu đặt phòng (bên dưới)
            dgvPhieu.Columns.Clear();
            dgvPhieu.Columns.Add("SoPhieu", "Số phiếu");
            dgvPhieu.Columns.Add("Khach", "Khách");
            dgvPhieu.Columns.Add("NgayNhan", "Ngày nhận");
            dgvPhieu.Columns.Add("NgayTraDuKien", "Ngày trả dự kiến");
            dgvPhieu.Columns.Add("Coc", "Cọc");
            dgvPhieu.Columns.Add("Kenh", "Kênh");
            dgvPhieu.Columns.Add("TrangThai", "Trạng thái");

            dgvPhong.AllowUserToAddRows = false;
            dgvChon.AllowUserToAddRows = false;
            dgvPhieu.AllowUserToAddRows = false;
        }

        private void NapDuLieuMau()
        {
            // Nạp dòng mẫu vào bảng Phòng
            dgvPhong.Rows.Add("A101", "Khu A", "2", "600000.00");
            dgvPhong.Rows.Add("A102", "Khu A", "3", "800000.00");
            dgvPhong.Rows.Add("B201", "Khu B", "4", "1200000.00");

            // Tạo các dòng trống sẵn cho 2 bảng còn lại
            for (int i = 0; i < 4; i++)
            {
                dgvChon.Rows.Add("", "", "");
                dgvPhieu.Rows.Add("", "", "", "", "", "", "");
            }
        }

        private void dgvChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}