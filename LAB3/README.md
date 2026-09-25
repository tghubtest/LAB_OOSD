# LAB 3: HỆ THỐNG QUẢN LÝ KHÁCH SẠN

Hi thầy, đây là thư mục lưu trữ toàn bộ mã nguồn, cơ sở dữ liệu và báo cáo bài Lab 3 của em thuộc học phần Phương pháp phát triển phần mềm hướng đối tượng (OOSD).

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Thị Thùy Trang
- **Mã số sinh viên (MSSV):** 1250080206
- **Lớp:** 12_ĐH_CNPM2 

## 2. Mục tiêu và nội dung bài Lab
Trong bài thực hành này, em đã xây dựng hoàn chỉnh ứng dụng "Hệ thống Quản lý Khách sạn" (WinForms) dựa trên các mục tiêu chính:
- **Khảo sát và phân loại nghiệp vụ:** phân tích các luồng lưu trữ, tra cứu, tính toán và xuất thống kê cho các mảng phòng, tiện nghi, dịch vụ, đền bù, hóa đơn.
- **Mô hình hóa UML:** 
  - Xác định các Class, Actor, Use Case và viết đặc tả Use Case trọng tâm.
  - Vẽ sơ đồ Use Case tổng quát/phân rã, biểu đồ lớp phân tích/chi tiết, biểu đồ trạng thái (PhieuDatPhong, HoaDon), biểu đồ tuần tự và biểu đồ hoạt động.
- **Thiết kế và khởi tạo CSDL:** xây dựng CSDL SQL Server với đầy đủ khóa chính, khóa ngoại, chỉ mục (Index) và ràng buộc (Check/Unique) cho các bảng `Phong`, `TienNghi`, `PhieuDatPhong`, `DichVu`, `PhieuDenBu`, `HoaDon`, `ThanhToan`.
- **Lập trình ứng dụng (WinForms):** triển khai giao diện theo kiến trúc 3 lớp (UI -> Service -> Data/Db) trên Visual Studio 2022.
- **Kiểm thử quy tắc nghiệp vụ (Business Rules):** test kỹ các trường hợp như kiểm tra sức chứa phòng, chặn trùng lịch đặt, ràng buộc 1 thiết bị/1 phòng/1 ngày, tự động cộng dồn dịch vụ dùng nhiều lần trong ngày, lập hóa đơn và thanh toán nhiều hình thức.

## 3. Môi trường và công cụ sử dụng
- **Hệ điều hành:** Windows 10 / Windows 11
- **Môi trường phát triển (IDE):** Visual Studio 2022 (.NET Framework 4.7.2)
- **Hệ quản trị CSDL:** SQL Server Management Studio (SSMS) / SQL Server LocalDB
- **Công cụ vẽ UML:** draw.io / StarUML

## 4. Các kết quả em đã hoàn thành
- [x] Tạo đầy đủ cấu trúc thư mục project (`Data`, `Services`, `Forms`).
- [x] Chạy script SQL khởi tạo thành công CSDL `QuanLyKhachSan` với dữ liệu mẫu.
- [x] Lập trình hoàn thiện các màn hình:
  - `FrmMain`: Màn hình điều hướng tổng thể.
  - `FrmDanhMuc`: Quản lý khu vực, nhân viên, loại tiện nghi, dịch vụ, quy định đền bù.
  - `FrmPhongTienNghi`: Quản lý danh mục phòng và phiếu lắp đặt/luân chuyển tiện nghi.
  - `FrmDatPhong`: Quản lý khách hàng, đặt phòng (chặn trùng lịch), ghi nhận người lưu trú và nhận phòng.
  - `FrmDichVu`: Ghi nhận dịch vụ dùng cho phiếu đang ở (tự động cộng dồn trong ngày).
  - `FrmTraPhong`: Lập phiếu đền bù, tính tổng hóa đơn (tiền phòng + dịch vụ), ghi nhận thanh toán linh hoạt và giải phóng phòng.
  - `FrmThongKe`: Thống kê doanh thu và báo cáo dịch vụ theo khoảng thời gian.
- [x] Đã đóng gói file báo cáo Word (chứa hình ảnh thực tế giao diện, CSDL chụp từ máy cá nhân) và dán link bài làm vào thư mục `LAB3/`.

## 5. Những lỗi đã gặp và cách sửa
Trong quá trình thiết kế giao diện Form (WinForms), em có vướng một số lỗi thiết kế và đã xử lý như sau:
1. **Lỗi thiếu nhãn chữ (Label) và sai tiêu đề cột DataGridView so với mẫu:**
   - *Nguyên nhân:* Các Form (`FrmPhongTienNghi`, `FrmDanhMuc`, `FrmDatPhong`, `FrmDichVu`, `FrmTraPhong`, `FrmThongKe`) ban đầu bị thiếu các control `Label` mô tả tên ô nhập (như "Số phòng:", "Phiếu lưu trú:", "Từ ngày:",...) làm giao diện chỉ có các khung trắng trơ trọi; đồng thời tiêu đề cột DataGridView hiển thị tên cột SQL thay vì tiếng Việt.
   - *Cách sửa:* Bổ sung đầy đủ các control `Label` mô tả, căn chỉnh lại vị trí `Location`, kích thước `Size` và thiết lập lại danh sách cột hiển thị tiếng Việt chuẩn theo đúng hình ảnh mẫu của thầy.
2. **Lỗi Hot Reload khi sửa giao diện lúc đang chạy ứng dụng (`Deleting/Renaming field requires restarting...`):**
   - *Nguyên nhân:* Tiến hành sửa đổi, đổi tên hoặc xóa các biến Control trong file `.Designer.cs` khi Visual Studio đang chạy ứng dụng ở chế độ Debug/Run làm tính năng Edit and Continue chặn lại.
   - *Cách sửa:* Bấm dừng chương trình (`Shift + F5`), tiến hành Rebuild lại toàn bộ dự án (`Ctrl + Shift + B`) rồi mới nhấn F5 để khởi chạy lại.
3. **Lỗi biên dịch thiếu hàm sự kiện DataGridView (`does not contain a definition for 'dgv..._CellContentClick'`):**
   - *Nguyên nhân:* Trong file `.Designer.cs` có đăng ký gán sự kiện click bảng (`CellContentClick`) nhưng trong file code-behind (`.cs`) tương ứng lại chưa khai báo hàm xử lý.
   - *Cách sửa:* Khai báo bổ sung các hàm sự kiện rỗng (như `dgvPhong_CellContentClick`, `dgvLichSu_CellContentClick`, `dgvTN_CellContentClick`) vào file `.cs` để giải quyết lỗi biên dịch.
4. **Lỗi giao diện Form bị phình to, vỡ khung (DPI Scaling / Font size):**
   - *Nguyên nhân:* Cỡ chữ đặt `10pt` kết hợp với tính năng thu phóng tự động (DPI Scaling) trên Windows 11 làm các khung TextBox, Button và DataGridView bị giãn quá to so với kích thước gốc.
   - *Cách sửa:* Cấu chỉnh lại `Font = 9pt`, thu nhỏ độ rộng các ô nhập liệu và thiết lập `RowTemplate.Height` của DataGridView gọn gàng vừa vặn đúng tỷ lệ form mẫu.

## 6. Hướng dẫn GV chạy thử bài làm của em

Thầy có thể kiểm tra bài làm của em theo các bước sau ạ:

1. **Tải mã nguồn:**
   - Clone repo về máy:
     ```bash
     git clone [https://github.com/tghubtest/LAB_OOSD.git](https://github.com/tghubtest/LAB_OOSD.git)
     ```
   - Mở thư mục `LAB_OOSD/LAB3/`.

2. **Khởi tạo CSDL:**
   - Mở SQL Server Management Studio (SSMS).
   - Mở file script SQL `QuanLyKhachSan.sql` trong thư mục `Database/` (hoặc copy script) và nhấn **Execute** để tạo Database `QuanLyKhachSan` cùng các bảng và dữ liệu mẫu.

3. **Chạy ứng dụng trên Visual Studio:**
   - Đảm bảo chuỗi kết nối trong file `App.config` đã trỏ đúng vào SQL Server của thầy/cô:
     ```xml
     <add name="QuanLyKhachSanDB" connectionString="Data Source=.; Initial Catalog=QuanLyKhachSan; Integrated Security=True" providerName="System.Data.SqlClient" />
     ```
   - Mở file solution `.sln` bằng **Visual Studio 2022**.
   - Nhấn **F5** (hoặc nút **Start**) để chạy thử ứng dụng.
