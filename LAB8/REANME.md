# BÁO CÁO LAB 8: HỆ THỐNG QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT

## I. THÔNG TIN CÁ NHÂN
* **Họ và tên:** Nguyễn Thị Thùy Trang
* **MSSV:** 1250080206
* **Lớp:** 12_ĐH_CNPM2

---

## II. MỤC TIÊU BÀI LAB
* **Phân tích nghiệp vụ:** Khảo sát và phân tích toàn diện các quy trình mua bán nước giải khát: danh mục nhãn hiệu, nhà cung ứng, nước giải khát; đơn đặt hàng và phiếu giao (tối đa 3 đợt); bán hàng theo tồn kho (`UPDLOCK`); phiếu hẹn giao nhiều đợt và phiếu ghi nợ cho khách quen.
* **Mô hình hóa UML:** Trả lời đầy đủ các yêu cầu thực hành bằng bộ mô hình UML từ pha phân tích (Use Case tổng quát, Use Case phân rã, Activity Diagram) đến pha thiết kế (Sequence Diagram, ERD 14 bảng).
* **Thiết kế CSDL SQL Server:** Xây dựng ERD triển khai, danh sách bảng và các ràng buộc toàn vẹn (QD01 - QD10); hiện thực bằng script T-SQL.
* **Hiện thực phần mềm C# WinForms:** Lập trình ứng dụng WinForms (.NET Framework 4.7.2) bám sát kiến trúc 3 lớp: `UI (WinForms)` → `Service` → `Data (DAL)` → `SQL Server`.
* **Kiểm thử hệ thống:** Xây dựng ma trận truy vết yêu cầu (Requirement → UML → Form/Service → CSDL → Test Case) và lập kịch bản kiểm thử với dữ liệu cụ thể.

---

## III. MÔI TRƯỜNG & CÔNG NGHỆ (ENVIRONMENT / VERSION)
* **Hệ điều hành:** Windows 10 / Windows 11
* **Công cụ lập trình (IDE):** Microsoft Visual Studio 2022
* **Nền tảng framework:** .NET Framework 4.7.2 (C# WinForms)
* **Hệ quản trị CSDL:** Microsoft SQL Server 2019 / 2022 (Management Studio - SSMS)
* **Công cụ vẽ mô hình:** Draw.io, PlantUML, Mermaid.live

---

## IV. NỘI DUNG ĐÃ THỰC HIỆN
1. **Pha Phân tích & Thiết kế UML:**
   * Lập bảng phân tích Đầu vào - Xử lý - Đầu ra (IPO Table) và định nghĩa các Tác nhân (Actor).
   * Tổng hợp 10 Quy tắc nghiệp vụ (QD01 đến QD10) và Quyết định triển khai.
   * Xây dựng sơ đồ Use Case tổng quát, Use Case phân rã, Activity Diagram bán hàng/giao hàng và Sequence Diagram lập phiếu ghi nợ.
2. **Xây dựng Cơ sở dữ liệu:**
   * Viết script T-SQL `QuanLyNuocGiaiKhat.sql` khởi tạo 14 bảng chuẩn hóa (NhanVien, KhachHang, NhaCungUng, NhanHieu, NuocGiaiKhat, DonDatHang, ChiTietDonDatHang, PhieuGiaoHang, ChiTietPhieuGiaoHang, HoaDon, ChiTietHoaDon, PhieuHenGiao, ChiTietPhieuHenGiao, PhieuGhiNo).
   * Tạo đầy đủ các khóa chính, khóa ngoại, ràng buộc `CHECK`, `UNIQUE` và dữ liệu mẫu (Test Data).
3. **Lập trình C# WinForms (3 Lớp):**
   * **Lớp Data:** Viết helper `Db.cs` thao tác SqlClient và `KetQuaXuLy.cs` để đóng gói kết quả trả về.
   * **Lớp Service:** Viết `BanHangService.cs` (kiểm tra kho `UPDLOCK`, trừ tồn kho trong Transaction, tự động tạo phiếu hẹn nếu thiếu kho) và `PhieuNoService.cs` (kiểm tra điều kiện ghi nợ cho Khách quen).
   * **Lớp UI:** Dựng các giao diện `FrmMain` (trang chủ điều hướng), `FrmDanhMuc` (quản lý danh mục), `FrmBanHang` (lập hóa đơn & giỏ hàng) và `FrmPhieuNo` (lập phiếu nợ).
4. **Kiểm thử & Truy vết:**
   * Lập bảng Ma trận truy vết yêu cầu (Traceability Matrix).
   * Thực hiện 4 Test Case với dữ liệu thực tế (bán cho khách vãng lai khi thiếu kho, bán cho khách quen tự động hẹn giao, lập phiếu nợ hợp lệ, chặn lập nợ sai số tiền).

---

## V. KẾT QUẢ ĐẠT ĐƯỢC
* [x] Tạo thành công CSDL SQL Server gồm 14 bảng đúng cấu trúc ERD.
* [x] Xây dựng xong ứng dụng C# WinForms khởi chạy giao diện trang chủ `FrmMain` điều hướng mượt mà.
* [x] Xử lý thành công giao dịch bán hàng an toàn dữ liệu bằng `SqlTransaction` kết hợp khóa `UPDLOCK`.
* [x] Phân luồng chính xác nghiệp vụ Khách vãng lai (từ chối giao phần thiếu) và Khách quen (giao phần có sẵn, tự tạo phiếu hẹn).
* [x] Báo cáo đầy đủ file Word, Script SQL, Source Code C# và đẩy thành công lên GitHub Repository.

---

## VI. LỖI GẶP PHẢI VÀ CÁCH KHẮC PHỤC
| STT | Lỗi gặp phải | Nguyên nhân | Cách khắc phục |
| :---: | :--- | :--- | :--- |
| 1 | Lỗi CS1061: `'FrmDanhMuc' does not contain a definition for 'dgvKhu_CellContentClick'` | Trong file Designer có dính sự kiện gán `dgvKhu.CellContentClick` nhưng file code `.cs` không có hàm xử lý tương ứng. | Mở file `FrmDanhMuc.Designer.cs`, xóa dòng gán sự kiện `CellContentClick` thừa. |
| 2 | Sơ đồ ERD PlantUML bị đè dây nối rối mắt trên Draw.io | Thuật toán auto-layout mặc định của PlantUML sắp xếp các khối thực thể chưa hợp lý. | Thêm các thẻ định hướng (`ortho`, `left to right direction`, `down`, `right`) để ép các dây nối vuông góc và xếp đúng tầng. |
| 3 | Lỗi cú pháp C#: `The name 'N' does not exist in the current context` | Sử dụng cú pháp tiền tố `N"..."` của SQL trực tiếp trong code C# (`N"Chờ giao hẹn"`). | Xóa ký tự `N` trước các chuỗi string trong code C# (chỉ giữ lại dấu ngoặc kép `"..."`). |
| 4 | Lỗi CS0246: `The type or namespace name 'Data'/'Services' could not be found` | Chưa khai báo directive `using` cho thư mục tầng Data và Services trong các Form UI. | Bổ sung `using QuanLyNuocGiaiKhat.Data;` và `using QuanLyNuocGiaiKhat.Services;` ở đầu các file Form. |

---

## VII. HƯỚNG DẪN KIỂM TRA / CHẠY LẠI
Dành cho Thầy/Cô khi tải bài về kiểm tra:

1. **Khởi tạo Cơ sở dữ liệu:**
   * Mở phần mềm SQL Server Management Studio (SSMS).
   * Mở file script `QuanLyNuocGiaiKhat.sql` trong thư mục bài nộp.
   * Nhấn **Execute (F5)** để khởi tạo Database `QuanLyNuocGiaiKhat` và tự động chèn dữ liệu mẫu.

2. **Mở và Chạy Dự Án C# WinForms:**
   * Mở thư mục `QuanLyNuocGiaiKhat`, kích kép vào file `QuanLyNuocGiaiKhat.sln` để mở trong Visual Studio.
   * Mở file `Data/Db.cs`, điều chỉnh lại chuỗi `ConnectionString` nếu Server Name SQL của máy khác mặc định (`Data Source=.`).
   * Nhấn **Ctrl + Shift + B** để Build toàn bộ Solution (đảm bảo Build thành công 0 lỗi).
   * Nhấn **F5** (hoặc nút **Start**) để khởi chạy ứng dụng.

3. **Kịch bản Test nhanh trên Giao diện:**
   * Mở **"Bán hàng - Thanh toán"** (`FrmBanHang`):
     * Chọn *Khách vãng lai* $\rightarrow$ Mua Pepsi lon số lượng 15 (Tồn kho chỉ có 10) $\rightarrow$ Bấm Thanh toán $\rightarrow$ Hệ thống sẽ báo lỗi từ chối giao vì kho không đủ.
     * Chọn *Khách quen* (`KH001`) $\rightarrow$ Mua Sting dâu số lượng 12 (Tồn kho chỉ có 5) $\rightarrow$ Bấm Thanh toán $\rightarrow$ Hệ thống báo thành công, trừ kho về 0 và tự động tạo Phiếu hẹn giao 7 chai còn thiếu.
   * Mở **"Phiếu ghi nợ"** (`FrmPhieuNo`):
     * Chọn Hóa đơn của Khách quen $\rightarrow$ Nhập số tiền nợ $\rightarrow$ Bấm Lưu $\rightarrow$ Ghi nhận thành công phiếu nợ vào CSDL.
