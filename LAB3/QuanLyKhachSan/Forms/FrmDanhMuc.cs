using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyKhachSan.Services;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService service = new DanhMucService();
        private string tabHienTai = "DichVu";

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            KhoiTaoBangKhung();
            ChonTab("DichVu");
        }

        private void KhoiTaoBangKhung()
        {
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.Columns.Add("Ma", "Mã");
            dgvDanhSach.Columns.Add("Ten", "Tên");
            dgvDanhSach.Columns.Add("LoaiVaiTro", "Loại / Vai trò");
            dgvDanhSach.Columns.Add("DonVi", "Đơn vị");
            dgvDanhSach.Columns.Add("DonGiaMuc", "Đơn giá / Mức");

            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.RowHeadersVisible = false;

            TaoDongTrong(6);
        }

        private void TaoDongTrong(int soDong)
        {
            dgvDanhSach.Rows.Clear();
            for (int i = 0; i < soDong; i++)
            {
                dgvDanhSach.Rows.Add("", "", "", "", "");
            }
        }

        private void ResetMenuFont()
        {
            Font fontThuong = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblMenuKhuVuc.Font = fontThuong;
            lblMenuNhanVien.Font = fontThuong;
            lblMenuLoaiTN.Font = fontThuong;
            lblMenuDichVu.Font = fontThuong;
            lblMenuQuyDinh.Font = fontThuong;
        }

        private void ChonTab(string tabName)
        {
            tabHienTai = tabName;
            ResetMenuFont();
            Font fontBold = new Font("Segoe UI", 10F, FontStyle.Bold);

            lblDonViVaiTro.Visible = true;
            txtDonViVaiTro.Visible = true;
            cboLoaiTN.Visible = false;
            lblGiaMuc.Visible = false;
            numGiaMuc.Visible = false;

            TaoDongTrong(6);

            switch (tabName)
            {
                case "KhuVuc":
                    lblMenuKhuVuc.Font = fontBold;
                    lblDonViVaiTro.Visible = false;
                    txtDonViVaiTro.Visible = false;
                    NapDataVaoKhung(service.LayKhuVuc(), "MaKhuVuc", "TenKhuVuc", "", "", "");
                    break;

                case "NhanVien":
                    lblMenuNhanVien.Font = fontBold;
                    lblDonViVaiTro.Text = "Vai trò:";
                    NapDataVaoKhung(service.LayNhanVien(), "MaNV", "HoTen", "VaiTro", "SoDienThoai", "");
                    break;

                case "LoaiTN":
                    lblMenuLoaiTN.Font = fontBold;
                    lblDonViVaiTro.Visible = false;
                    txtDonViVaiTro.Visible = false;
                    NapDataVaoKhung(service.LayLoaiTienNghi(), "MaLoaiTN", "TenLoaiTN", "", "", "");
                    break;

                case "DichVu":
                    lblMenuDichVu.Font = fontBold;
                    lblDonViVaiTro.Text = "Đơn vị / Vai trò:";
                    txtMa.Text = "DV01";
                    txtTen.Text = "Ăn sáng";
                    txtDonViVaiTro.Text = "Suất";
                    NapDataVaoKhung(service.LayDichVu(), "MaDV", "TenDV", "", "DonViTinh", "DonGia");
                    break;

                case "QuyDinh":
                    lblMenuQuyDinh.Font = fontBold;
                    lblDonViVaiTro.Text = "Loại TN:";
                    txtDonViVaiTro.Visible = false;
                    cboLoaiTN.Visible = true;
                    cboLoaiTN.DataSource = service.LayLoaiTienNghi();
                    cboLoaiTN.DisplayMember = "TenLoaiTN";
                    cboLoaiTN.ValueMember = "MaLoaiTN";
                    NapDataVaoKhung(service.LayQuyDinhDenBu(), "MaQuyDinh", "MucDoThietHai", "TenLoaiTN", "", "MucDenBu");
                    break;
            }
        }

        private void NapDataVaoKhung(DataTable dt, string col1, string col2, string col3, string col4, string col5)
        {
            if (dt == null) return;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i >= dgvDanhSach.Rows.Count)
                {
                    dgvDanhSach.Rows.Add("", "", "", "", "");
                }

                DataRow row = dt.Rows[i];
                dgvDanhSach.Rows[i].Cells[0].Value = string.IsNullOrEmpty(col1) ? "" : row[col1]?.ToString();
                dgvDanhSach.Rows[i].Cells[1].Value = string.IsNullOrEmpty(col2) ? "" : row[col2]?.ToString();
                dgvDanhSach.Rows[i].Cells[2].Value = string.IsNullOrEmpty(col3) ? "" : row[col3]?.ToString();
                dgvDanhSach.Rows[i].Cells[3].Value = string.IsNullOrEmpty(col4) ? "" : row[col4]?.ToString();
                dgvDanhSach.Rows[i].Cells[4].Value = string.IsNullOrEmpty(col5) ? "" : row[col5]?.ToString();
            }
        }

        private void lblMenuKhuVuc_Click(object sender, EventArgs e) => ChonTab("KhuVuc");
        private void lblMenuNhanVien_Click(object sender, EventArgs e) => ChonTab("NhanVien");
        private void lblMenuLoaiTN_Click(object sender, EventArgs e) => ChonTab("LoaiTN");
        private void lblMenuDichVu_Click(object sender, EventArgs e) => ChonTab("DichVu");
        private void lblMenuQuyDinh_Click(object sender, EventArgs e) => ChonTab("QuyDinh");

        private void btnThem_Click(object sender, EventArgs e)
        {
            KetQuaXuLy res = KetQuaXuLy.Fail("Chưa chọn danh mục.");

            switch (tabHienTai)
            {
                case "KhuVuc":
                    res = service.ThemKhu(txtMa.Text.Trim(), txtTen.Text.Trim());
                    break;
                case "NhanVien":
                    res = service.ThemNhanVien(txtMa.Text.Trim(), txtTen.Text.Trim(), txtDonViVaiTro.Text.Trim(), numGiaMuc.Value.ToString());
                    break;
                case "LoaiTN":
                    res = service.ThemLoaiTN(txtMa.Text.Trim(), txtTen.Text.Trim());
                    break;
                case "DichVu":
                    res = service.ThemDichVu(txtMa.Text.Trim(), txtTen.Text.Trim(), txtDonViVaiTro.Text.Trim(), numGiaMuc.Value);
                    break;
                case "QuyDinh":
                    res = service.ThemQuyDinh(txtMa.Text.Trim(), cboLoaiTN.SelectedValue?.ToString(), txtTen.Text.Trim(), numGiaMuc.Value);
                    break;
            }

            MessageBox.Show(res.ThongBao, "Thông báo", MessageBoxButtons.OK, res.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (res.ThanhCong) ChonTab(tabHienTai);
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}