using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        readonly PhongTienNghiService service = new PhongTienNghiService();

        public FrmPhongTienNghi()
        {
            InitializeComponent();
        }

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {
            KhoiTaoBang();
            TaiDuLieuPhong();
        }

        private void KhoiTaoBang()
        {
            dgvPhong.Columns.Clear();
            dgvPhong.Columns.Add("Phong", "Phòng");
            dgvPhong.Columns.Add("Khu", "Khu");
            dgvPhong.Columns.Add("SucChua", "Sức chứa");
            dgvPhong.Columns.Add("DonGia", "Đơn giá");
            dgvPhong.Columns.Add("TrangThai", "Trạng thái");

            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.RowHeadersVisible = false;
        }

        private void TaiDuLieuPhong()
        {
            DataTable dt = service.LayPhong();
            dgvPhong.Rows.Clear();

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvPhong.Rows.Add(
                        dr["SoPhong"]?.ToString(),
                        dr["TenKhuVuc"]?.ToString(),
                        dr["SoNguoiToiDa"]?.ToString(),
                        string.Format("{0:0.00}", dr["DonGiaNgay"]),
                        dr["TrangThai"]?.ToString()
                    );
                }
            }

            // Chọn dòng đầu tiên điền vào TextBox mẫu giống ảnh thầy
            if (dgvPhong.Rows.Count > 0)
            {
                txtPhong.Text = dgvPhong.Rows[0].Cells[0].Value?.ToString();
                txtKhu.Text = dgvPhong.Rows[0].Cells[1].Value?.ToString();
                txtMax.Text = dgvPhong.Rows[0].Cells[2].Value?.ToString();
                txtGia.Text = dgvPhong.Rows[0].Cells[3].Value?.ToString();
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            KetQuaXuLy res = service.LapDat(
                txtSoLD.Text.Trim(),
                txtTN.Text.Trim(),
                txtPhongLD.Text.Trim(),
                DateTime.Now,
                txtTinhTrang.Text.Trim(),
                "NV01", // Mặc định NV01
                ""
            );

            MessageBox.Show(res.ThongBao, "Thông báo", MessageBoxButtons.OK, res.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (res.ThanhCong)
            {
                TaiDuLieuPhong();
            }
        }
    }
}