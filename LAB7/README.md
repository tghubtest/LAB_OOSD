# BÁO CÁO LAB 7: HỆ THỐNG QUẢN LÝ NHÂN SỰ CÔNG TY SƠN ĐÔNG Á

## I. THÔNG TIN CÁ NHÂN
* **Họ và tên:** Nguyễn Thị Thùy Trang
* **MSSV:** 1250080206
* **Lớp:** 12_ĐH_CNPM2
---

## II. MỤC TIÊU BÀI LAB
* **Phân tích nghiệp vụ:** Khảo sát và phân tích toàn diện các quy trình: tuyển dụng - thử việc, hợp đồng lao động và bảo hiểm (BHYT, BHXH), quyết định lương - chức vụ, kế hoạch làm việc tuần, chấm công, phụ trội (tăng ca, lễ), khen thưởng - kỷ luật và tính lương hằng tháng tại công ty sơn Đông Á.
* **Mô hình hóa UML:** Trả lời đầy đủ các yêu cầu thực hành bằng bộ mô hình UML từ pha phân tích (Use Case, Activity, State) đến pha thiết kế (Sequence, Class, BCE Class Design).
* **Thiết kế CSDL SQL Server:** Xây dựng ERD, danh sách bảng và ràng buộc nhất quán với mô hình lớp; hiện thực bằng script T-SQL.
* **Hiện thực phần mềm C# WinForms:** Lập trình ứng dụng WinForms (.NET Framework 4.7.2) bám sát kiến trúc 3 lớp: `UI (WinForms)` → `Service/BLL` → `Data/DAL` → `SQL Server`.
* **Kiểm thử hệ thống:** Xây dựng ma trận truy vết yêu cầu (Requirement → UML → Form/Service → CSDL → Test case) và lập kịch bản kiểm thử với dữ liệu cụ thể.

---

## III. MÔI TRƯỜNG & CÔNG NGHỆ (ENVIRONMENT / VERSION)
* **Hệ điều hành:** Microsoft Windows 10 / Windows 11 (64-bit)
* **Môi trường phát triển (IDE):** Microsoft Visual Studio 2019 / 2022
* **Nền tảng framework:** .NET Framework 4.7.2 (C# WinForms)
* **Hệ quản trị CSDL:** Microsoft SQL Server 2019 / 2022 (Management Studio - SSMS)
* **Công cụ vẽ sơ đồ UML:** PlantUML / PlantText (Standard BCE Color Scheme: Yellow `#FFFFCC`, Red `#A31515`)

---

## IV. NỘI DUNG ĐÃ THỰC HIỆN

### 1. Phân tích nghiệp vụ & Quy tắc
* **Bảng Đầu vào - Xử lý - Đầu ra:** Phân tích 6 nhóm nghiệp vụ chính (Tuyển dụng, Hợp đồng & Bảo hiểm, Quyết định nhân sự, Chấm công & Phụ trội, Khen thưởng/Kỷ luật, Tính lương).
* **Bảng Tác nhân:** Xác định 5 Actor cốt lõi (*Nhân viên nhân sự, Trưởng phòng/ban, Ban chấm công, Giám đốc, Kế toán tiền lương*).
* **Bảng Quy tắc nghiệp vụ:** Thiết lập 10 quy tắc nghiệp vụ (**BR01 - BR10**), đặc biệt chú trọng **BR04** (Chỉ hợp đồng dài hạn mới làm hồ sơ bảo hiểm) và **BR10** (Quyết định khen thưởng tự động sinh Phiếu Chi tài chính).

### 2. Xây dựng bộ sơ đồ UML (Pha Phân tích & Pha Thiết kế)
* **Biểu đồ Use Case:** Use case tổng quát hệ thống và Biểu đồ phân rã Use Case *Tuyển dụng đến Hợp đồng* kèm bảng đặc tả chi tiết.
* **Biểu đồ Trạng thái (State Diagram):** Mô tả trạng thái của lớp `NhanVien` (*Thử việc → Chính thức → Chấm dứt*) và lớp `QuyetDinh` (*Chờ ký → Đã ký → Đã thực thi*).
* **Biểu đồ Tuần tự (Sequence Diagram):** Mô tả luồng tương tác Boundary-Control-Entity cho chức năng *Lập quyết định khen thưởng* (có xử lý Transaction).
* **Biểu đồ Lớp (Class Diagram):** Biểu đồ lớp phân tích, biểu đồ lớp thiết kế chi tiết và biểu đồ thiết kế theo chức năng (BCE Pattern).
* **Biểu đồ Hoạt động (Activity Diagram):** Mô tả luồng xử lý tuyển dụng, lập HĐLĐ và kiểm tra điều kiện rẽ nhánh bảo hiểm BR04.

### 3. Thiết kế & Khởi tạo CSDL SQL Server
* **Sơ đồ ERD:** Chuẩn hóa các thực thể theo dạng Chân chim (Crow's foot).
* **Danh sách bảng & Ràng buộc:** 11 bảng dữ liệu cùng các ràng buộc `UNIQUE`, `CHECK`, `FOREIGN KEY` bảo đảm toàn vẹn dữ liệu.
* **Script T-SQL:** Viết code SQL tạo Database `QL_NhanSuDongA`, tạo bảng, ràng buộc, thủ tục lưu trữ (`Stored Procedure`) và dữ liệu mẫu.

### 4. Lập trình C# WinForms theo Kiến trúc 3 Lớp
* **Khởi tạo FrmMain:** Thiết kế giao diện Dashboard trang chủ chứa 6 nút bấm điều hướng chính dạng khối trực quan.
* **Khởi tạo FrmKhenThuong:** Form nghiệp vụ trọng tâm với giao diện nhập liệu đầy đủ.
* **Tầng Service (BLL) & Data (DAL):** Viết class `KhenThuongService` kiểm tra logic nghiệp vụ và `QDKhenThuongDAL` thực thi câu lệnh SQL với `SqlTransaction` để đảm bảo lưu đồng thời Quyết định & Phiếu chi (BR10).

---

## V. KẾT QUẢ ĐẠT ĐƯỢC
* [x] Complete 100% tài liệu phân tích nghiệp vụ, bảng đặc tả và ma trận BR.
* [x] Complete 100% bộ mô hình UML chuẩn hóa (màu sắc, chuẩn thiết kế BCE).
* [x] Complete 100% thiết kế CSDL SQL Server và chạy thành công Script SQL tạo bảng/dữ liệu mẫu.
* [x] Complete 100% cấu trúc dự án WinForms 3 lớp (`UI → Service → Data`).
* [x] Form `FrmMain` hiển thị đúng giao diện điều hướng tổng thể.
* [x] Form `FrmKhenThuong` kết nối thành công SQL Server, thực thi được transaction thêm mới Quyết định khen thưởng và tự động sinh Phiếu Chi.
* [ ] *Đang thực hiện:* Hoàn thiện các form phụ còn lại (`FrmTuyenDung`, `FrmChamCong`, `FrmLuong`) và lập bảng Kịch bản kiểm thử (Test Cases).

---

## VI. LỖI GẶP PHẢI VÀ CÁCH KHẮC PHỤC

| STT | Lỗi gặp phải (Error) | Nguyên nhân (Cause) | Cách khắc phục (Solution) |
| :--- | :--- | :--- | :--- |
| **1** | Lỗi biên dịch `string does not contain a definition for 'Text'` tại `FrmKhenThuong.cs`. | Khai báo trùng tên biến local `string txtSoTien` với tên điều khiển TextBox `txtSoTien` trên giao diện, khiến C# hiểu nhầm thuộc tính. | Đổi tên biến local chứa chuỗi nhập liệu thành `sSoTien` (`string sSoTien = txtSoTien.Text.Trim();`). |
| **2** | Lỗi `The name 'cboMaNV' does not exist in the current context`. | Tên ComboBox trong file `FrmKhenThuong.Designer.cs` đặt là `cboNhanVien`, nhưng file code `.cs` gọi tên `cboMaNV`. | Đồng bộ lại tên control trong file `.cs` thành `cboNhanVien` cho khớp hoàn toàn với Designer. |
| **3** | Visual Studio báo vạch đỏ gạch chân class `KhenThuongService`. | Chưa tạo file class BLL/DAL ở tầng dưới khiến Form không tìm thấy lớp điều khiển tương ứng. | Tạo file class `KhenThuongService.cs` chứa đầy đủ 2 class `KhenThuongService` và `QDKhenThuongDAL`. |
| **4** | Lỗi kết nối CSDL SQL Server khi chạy ứng dụng. | Chuỗi `connectionString` khai báo sai tên Server Instance hoặc sai tên Database `QL_NhanSuDongA`. | Cấu hình lại chuỗi kết nối dạng `Data Source=.;Initial Catalog=QL_NhanSuDongA;Integrated Security=True` (hoặc dùng tên Instance `.\SQLEXPRESS`). |

---

## VII. HƯỚNG DẪN GIẢNG VIÊN KIỂM TRA & CHẠY LẠI CHƯƠNG TRÌNH

Để Giảng viên có thể kiểm tra và chạy lại dự án một cách thuận tiện nhất, xin vui lòng thực hiện theo các bước sau:

### Bước 1: Khởi tạo Cơ sở dữ liệu SQL Server
1. Mở phần mềm **SQL Server Management Studio (SSMS)**.
2. Mở file script `Script_QL_NhanSuDongA.sql` đi kèm trong thư mục project (hoặc copy đoạn script SQL trong Báo cáo).
3. Bấm **Execute (F5)** để tự động tạo Database `QL_NhanSuDongA`, các bảng, ràng buộc và dữ liệu mẫu.

### Bước 2: Cấu hình dự án trên Visual Studio
1. Khởi động **Visual Studio** và mở file solution `QL_NHANSU.sln`.
2. Mở file `KhenThuongService.cs` (hoặc file `App.config`), kiểm tra biến `connectionString`:
   ```csharp
   private string connectionString = "Data Source=.;Initial Catalog=QL_NhanSuDongA;Integrated Security=True";
   ```
   *(Lưu ý: Nếu SQL Server trên máy thầy/cô sử dụng tên Instance riêng, xin vui lòng thay dấu `.` bằng tên Server tương ứng, ví dụ: `.\SQLEXPRESS`)*.

### Bước 3: Biên dịch và Khởi chạy ứng dụng
1. Trên thanh Menu của Visual Studio, chọn **Build** → **Build Solution** (hoặc bấm `Ctrl + Shift + B`) để đảm bảo không còn lỗi biên dịch.
2. Bấm phím **F5** (hoặc nút **Start**) để khởi chạy ứng dụng.
3. Màn hình **`FrmMain` (Quản lý Nhân sự Đông Á)** sẽ xuất hiện.
4. Click chọn nút **`3. Lập quyết định khen thưởng - kỷ luật`** để mở form `FrmKhenThuong`.
5. Nhập các thông tin mẫu (Mã QĐ: `QD100`, Chọn Nhân viên: `NV01`, Lý do: `Hoàn thành xuất sắc nhiệm vụ`, Số tiền: `2000000`) và bấm **Lập Quyết Định** để kiểm tra tính năng kết nối CSDL và sinh tự động Phiếu chi (BR10).
