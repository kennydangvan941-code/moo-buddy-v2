# 3. Parent Setup - Task & Reward Configuration

## US 3.1: Task Library & Customization (Quản lý nhiệm vụ)
**User Role:** Phụ huynh.  
**Nội dung:** Bố mẹ chọn hoặc tạo các công việc hàng ngày cho bé để đổi lấy Cỏ.  
**Acceptance Criteria:**
- Thư viện mẫu: Hiển thị danh sách nhiệm vụ gợi ý dựa trên nhóm tuổi đã chọn (VD: 3-5 tuổi: Cất đồ chơi; 9-11 tuổi: Quét nhà).
- Tạo nhiệm vụ mới: Cho phép bố mẹ tự nhập tên công việc riêng của gia đình.
- Thiết lập giá trị: Bố mẹ gán level cho mỗi task, hệ thống tự tính toán convert sang số bó cỏ: dễ 1 bó, trung bình 2 bó, khó 4 bó, siêu khó 6 bó.
- Lịch trình: Chọn tần suất thực hiện (Hàng ngày, các ngày trong tuần, hoặc chỉ cuối tuần).

---

## US 3.2: Reward Store Setup (Cấu hình kho quà tặng)
**User Role:** Phụ huynh.  
**Nội dung:** Bố mẹ thiết lập các phần thưởng "đời thực" mà bé có thể dùng Gold để đổi.  
**Acceptance Criteria:**
- Tạo món quà: Nhập tên quà (VD: Đi xem phim, Mua kem, Thêm 30p xem iPad).
- Định giá Gold: Bố mẹ quy định cần bao nhiêu Gold để đổi được món quà đó (Dựa trên logic: Sữa > Gold > Quà).
- Hình ảnh quà: Cho phép chụp ảnh món quà thật hoặc chọn icon minh họa để bé có động lực.

---

## US 3.3: Task Approval Logic (Cấu hình cách phê duyệt)
**User Role:** Phụ huynh.  
**Nội dung:** Thiết lập cách thức bé minh chứng đã hoàn thành việc.  
**Acceptance Criteria:**
- Cung cấp các option cho mỗi nhiệm vụ:
  - Bé tự bấm: Chỉ cần nhấn hoàn thành là được cộng cỏ.
  - Chụp ảnh: Bé phải chụp ảnh kết quả gửi lên để bố mẹ duyệt mới được cộng cỏ.
  - Bố mẹ xác nhận: Bé làm xong, bố mẹ phải mở máy mình bấm duyệt thủ công.

---

## US 3.4: Assign Task Screen (Giao nhiệm vụ cho bé)
**User Role:** Phụ huynh.  
**Nội dung:** Phụ huynh chọn các nhiệm vụ cụ thể để đưa vào danh sách "To-do list" hàng ngày của bé.  
**Acceptance Criteria:**
- Giao diện danh sách: Hiển thị toàn bộ các nhiệm vụ từ Thư viện mẫu và Nhiệm vụ tự tạo.
- Thao tác chọn: Cho phép phụ huynh tích chọn (Checkbox) nhiều nhiệm vụ cùng lúc để giao.
- Thiết lập tần suất: Với mỗi nhiệm vụ được chọn, phụ huynh có thể tinh chỉnh nhanh:
  - Lặp lại: Mỗi ngày, Thứ 2-4-6, Thứ 7-CN...
  - Khung giờ: Sáng, chiều hoặc tối (để App gửi thông báo nhắc bé).
- Nút xác nhận: Sau khi nhấn "Giao việc", hệ thống sẽ đẩy các nhiệm vụ này xuống DashBoard cho bé.

---

## US 3.6: Task Management Dashboard (Quản lý các việc đã giao)
**User Role:** Phụ huynh.  
**Nội dung:** Xem lại danh sách các việc bé đang phải làm để điều chỉnh hoặc tạm dừng.  
**Acceptance Criteria:**
- Hiển thị danh sách các nhiệm vụ đang "Active" (đang thực hiện).
- Bật/Tắt (Toggle): Cho phép phụ huynh tạm dừng một nhiệm vụ mà không cần xóa (ví dụ: Bé ốm nên không phải làm việc nhà).
- Chỉnh sửa nhanh: Thay đổi số lượng Cỏ thưởng nếu thấy nhiệm vụ đó khó/dễ hơn dự kiến.
- Xóa nhiệm vụ: Gỡ bỏ hoàn toàn nhiệm vụ khỏi lịch trình của bé.