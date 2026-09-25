using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong : Form
    {
        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            KhoiTaoCacBang();
        }

        private void KhoiTaoCacBang()
        {
            // 1. Bảng Phòng
            dgvPhong.Columns.Clear();
            dgvPhong.Columns.Add("Phong", "Phòng");
            dgvPhong.Columns.Add("DonGiaNgay", "Đơn giá/ngày");

            // 2. Bảng Tiện nghi
            dgvTN.Columns.Clear();
            dgvTN.Columns.Add("TienNghi", "Tiện nghi");
            dgvTN.Columns.Add("Loai", "Loại");
            dgvTN.Columns.Add("TinhTrang", "Tình trạng");

            // 3. Bảng Tiện nghi đền bù
            dgvDBChon.Columns.Clear();
            dgvDBChon.Columns.Add("TN_DenBu", "Tiện nghi đền bù");
            dgvDBChon.Columns.Add("MucDo", "Mức độ");
            dgvDBChon.Columns.Add("SoTien", "Số tiền");

            // 4. Bảng Hóa đơn
            dgvHD.Columns.Clear();
            dgvHD.Columns.Add("HoaDon", "Hóa đơn");
            dgvHD.Columns.Add("PhieuDat", "Phiếu đặt");
            dgvHD.Columns.Add("TienPhong", "Tiền phòng");
            dgvHD.Columns.Add("TienDichVu", "Tiền dịch vụ");
            dgvHD.Columns.Add("TongTien", "Tổng tiền");
            dgvHD.Columns.Add("TrangThai", "Trạng thái");

            dgvPhong.AllowUserToAddRows = false;
            dgvTN.AllowUserToAddRows = false;
            dgvDBChon.AllowUserToAddRows = false;
            dgvHD.AllowUserToAddRows = false;

            // Nạp dòng trống sẵn
            for (int i = 0; i < 4; i++)
            {
                dgvPhong.Rows.Add("", "");
                dgvTN.Rows.Add("", "", "");
                dgvDBChon.Rows.Add("", "", "");
                dgvHD.Rows.Add("", "", "", "", "", "");
            }
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lập hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoàn tất thủ tục trả phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}