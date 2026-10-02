# LAB 4: Hệ thống phần mềm Cửa hàng online “e-SHOPPING”

## 1. Thông tin cá nhân
* **Họ và tên:** Nguyễn Thị Thùy Trang
* **MSSV:** 1250080206
* **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng

## 2. Mục tiêu
- Phân tích mô tả nghiệp vụ của hệ thống e-SHOPPING, phân biệt chức năng bên trong hệ thống với ba hệ thống/dịch vụ bên ngoài: hệ thống quản lý sản phẩm, dịch vụ thanh toán trực tuyến và dịch vụ email.
- Xây dựng đầy đủ bộ mô hình UML theo trình tự pha phân tích - pha thiết kế: use case, lớp phân tích, trạng thái, tuần tự, lớp thiết kế, thiết kế theo chức năng, hoạt động.
- Thiết kế CSDL SQL Server nhất quán với mô hình lớp; hiện thực prototype bằng C# WinForms (.NET Framework 4.7.2) theo kiến trúc UI → Service/Adapter → Data.
-Kiểm thử theo kịch bản và truy vết Yêu cầu → UML → Form/Service → Bảng CSDL → Test case.

## 3. Môi trường và công nghệ sử dụng
* **Ngôn ngữ & Framework:** C# (WinForms code-only, không dùng Designer để tránh conflict), .NET Framework 4.7.2.
* **Cơ sở dữ liệu:** Microsoft SQL Server.
* **Công cụ phát triển:** Visual Studio, SQL Server Management Studio (SSMS).

## 4. Nội dung đã thực hiện
* Thiết kế giao diện WinForms hiện đại (Flat Design) cho các form: `FrmMain`, `FrmTimKiem`, `FrmDatHang`.
* Cài đặt thành công logic tính toán phí giao hàng dựa trên hình thức và tổng tiền (BR01, BR02, BR03, BR04) thông qua lớp `DatHangServiceAdapter`.
* Thực hiện kết nối hệ thống với CSDL SQL Server để lưu thông tin vào bảng `DonHang`.
* Xây dựng kịch bản kiểm thử (8 Test Cases) và lập bảng truy vết hệ thống (Traceability Matrix) vào file báo cáo Word.

## 5. Các lỗi gặp phải và cách khắc phục
* **Lỗi 1:** `FOREIGN KEY constraint` khi bấm thanh toán do bảng `KhachHang` trống, không tìm thấy `MaKH = 1`.
  * *Cách khắc phục:* Viết script `INSERT` dữ liệu mồi khách hàng trực tiếp trên SQL Server.
* **Lỗi 2:** `Cannot insert explicit value for identity column` khi chạy script chèn dữ liệu mồi.
  * *Cách khắc phục:* Bọc câu lệnh `INSERT` bằng khối lệnh `SET IDENTITY_INSERT KhachHang ON / OFF` để cấp quyền chèn ID thủ công.
* **Lỗi 3:** Không lưu được code class `DatHangServiceAdapter` do thiếu khai báo namespace.
  * *Cách khắc phục:* Đóng gói lại hàm xử lý vào bên trong cấu trúc `namespace` và `class` chuẩn của C#.

## 6. Hướng dẫn kiểm tra/chạy lại
1. **Khôi phục CSDL:** 
   * Mở SSMS, chạy file script SQL đi kèm để tạo database `eSHOPPING_Lab4` với các bảng `KhachHang`, `DonHang`.
   * Chạy đoạn lệnh mồi dữ liệu khách hàng (MaKH = 1) để đảm bảo không bị lỗi khóa ngoại khi test thanh toán.
2. **Chạy ứng dụng:**
   * Mở file solution (`.sln`) bằng Visual Studio.
   * Cập nhật lại chuỗi kết nối (`ConnectionString`) trong file `DatHangServiceAdapter.cs` cho khớp với tên Server của thầy/cô.
   * Nhấn `F5` để Build và chạy chương trình.
3. **Thao tác kiểm thử:**
   * Tại màn hình chính, chọn "Đặt hàng - Thanh toán".
   * Nhập số tiền và chọn hình thức giao hàng (THUONG / NHANH / TRONG_NGAY) để hệ thống tự động tính phí ship theo đúng các kịch bản TC03 - TC06 trong báo cáo.
