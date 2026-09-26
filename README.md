# Bài tập Cơ sở Lập trình C# - Buổi 6: Mảng và Thuật toán

## 👨‍🎓 Thông tin sinh viên
* **Họ và tên:** Võ Thanh Viễn
* **Chuyên ngành:** Kỹ thuật Phần mềm
* **Trường:** Đại học Kinh tế TP.HCM (UEH)

## 📚 Giới thiệu dự án
Kho lưu trữ này chứa mã nguồn giải quyết các bài tập thực hành C# của Buổi 6. Toàn bộ mã nguồn được thiết kế nghiêm ngặt theo chuẩn kiến trúc phân tầng (tách biệt hoàn toàn tầng Logic thuật toán và tầng Giao tiếp người dùng trong `Main`). Cách tiếp cận này giúp rèn luyện tư duy lập trình mô-đun hóa và tối ưu khả năng tái sử dụng mã (Clean Code).

## 🚀 Chi tiết các bài tập

### Bài Tập 1: Xử lý Mảng 1 Chiều (Single Dimension Arrays)
* Tính giá trị trung bình của các phần tử.
* Kiểm tra sự tồn tại và tìm chỉ số (index) của phần tử.
* Xóa một phần tử cụ thể khỏi mảng (tạo mảng mới, chống tràn bộ nhớ).
* Tìm giá trị lớn nhất (Max) và nhỏ nhất (Min).
* Đảo ngược mảng (Reverse).
* Nhận diện các giá trị lặp lại trong mảng.
* Xóa phần tử trùng lặp (giữ lại các giá trị độc nhất - Unique Array).

### Bài Tập 2: Thuật toán Cơ bản (Basic Algorithms)
* **Bubble Sort:** Thuật toán sắp xếp nổi bọt áp dụng cho mảng số nguyên.
* **Linear Search:** Thuật toán tìm kiếm tuyến tính để kiểm tra sự xuất hiện của một từ vựng cụ thể trong một chuỗi văn bản (có xử lý không phân biệt chữ hoa/chữ thường).

### Bài Tập 3: Xử lý Ma trận (2D Arrays / Matrices)
* Tạo ma trận số nguyên ngẫu nhiên kích thước $N \times M$.
* In ma trận với định dạng căn lề chuẩn xác.
* Trích xuất dữ liệu của hàng $i$ hoặc cột $j$ thành mảng 1 chiều.
* Tìm giá trị lớn nhất của toàn bộ ma trận.
* Tìm giá trị nhỏ nhất trên một hàng/cột cụ thể (tái sử dụng thuật toán từ Bài 1).
* Chuyển vị ma trận (Transpose ma trận $N \times M$ thành ma trận $M \times N$).
* Trích xuất các phần tử trên đường chéo chính và đường chéo phụ (tự động phát hiện và chỉ áp dụng cho ma trận vuông $N \times N$).

## 🛠 Hướng dẫn chạy chương trình
1. Clone kho lưu trữ này về máy cục bộ.
2. Mở giải pháp (Solution) bằng **Visual Studio**.
3. Cuộn xuống cuối file, bên trong hàm `Main`, tiến hành bỏ ghi chú (uncomment) hàm tương ứng với bài tập bạn muốn kiểm thử (`BaiTap01()`, `BaiTap02()`, hoặc `BaiTap03()`).
4. Nhấn `F5` hoặc nút **Start** để biên dịch và chạy chương trình trên Console.
