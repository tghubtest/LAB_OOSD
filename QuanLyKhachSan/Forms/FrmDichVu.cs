using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDichVu : Form
    {
        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            KhoiTaoBang();
        }

        private void KhoiTaoBang()
        {
            dgvLichSu.Columns.Clear();
            dgvLichSu.Columns.Add("SoPhieu", "Số phiếu");
            dgvLichSu.Columns.Add("Phong", "Phòng");
            dgvLichSu.Columns.Add("Ngay", "Ngày");
            dgvLichSu.Columns.Add("DichVu", "Dịch vụ");
            dgvLichSu.Columns.Add("SoLuong", "Số lượng");
            dgvLichSu.Columns.Add("DonGia", "Đơn giá");
            dgvLichSu.Columns.Add("ThanhTien", "Thành tiền");

            dgvLichSu.AllowUserToAddRows = false;
            dgvLichSu.RowHeadersVisible = false;
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tạo các dòng trống mẫu
            for (int i = 0; i < 6; i++)
            {
                dgvLichSu.Rows.Add("", "", "", "", "", "", "");
            }
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ghi nhận sử dụng dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}