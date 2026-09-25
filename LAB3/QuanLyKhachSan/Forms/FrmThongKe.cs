using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            KhoiTaoBang();
        }

        private void KhoiTaoBang()
        {
            dgvDV.Columns.Clear();
            dgvDV.Columns.Add("MaDV", "Mã DV");
            dgvDV.Columns.Add("TenDV", "Tên dịch vụ");
            dgvDV.Columns.Add("TongSoLuong", "Tổng số lượng");
            dgvDV.Columns.Add("TongTien", "Tổng tiền");

            dgvDV.AllowUserToAddRows = false;
            dgvDV.RowHeadersVisible = false;
            dgvDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tạo các dòng trống sẵn mẫu
            for (int i = 0; i < 5; i++)
            {
                dgvDV.Rows.Add("", "", "", "");
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            lblPhieuDat.Text = "Phiếu đặt: 28";
            lblDangO.Text = "Đang ở: 7";
            lblHoaDon.Text = "Hóa đơn: 21";
            lblDoanhThu.Text = "Doanh thu HĐ: 52.600.000 đ";
            lblDenBu.Text = "Tổng đền bù: 2.100.000 đ";

            MessageBox.Show("Thống kê dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}