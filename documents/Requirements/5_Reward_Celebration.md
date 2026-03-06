# 5. Reward & Celebration (Khen thưởng & Chúc mừng)

## US 5.1: Milk Harvest & Micro-Economy (Thu hoạch sữa & Kinh tế vi mô)
**User Role:** Bé.  
**Nội dung:** Bé thu hoạch sữa để tích lũy những đồng vàng giá trị.  
**Acceptance Criteria:**
- Tỷ giá chốt: 01 Bịch sữa từ bò trưởng thành = 10 Gold.
- Hiệu ứng: 10 đồng xu vàng rơi chậm rãi vào hũ kèm tiếng "keng keng" vui tai.
- Giá trị vật phẩm:
  - Bê con mới: 50 Gold (5 ngày vắt sữa).
  - Nâng cấp chuồng: 80 Gold (8 ngày vắt sữa).

---

## US 5.2: Parent’s Love & Bonus (Khen thưởng từ bố mẹ)
**User Role:** Phụ huynh.  
**Nội dung:** Bố mẹ chủ động khen thưởng khi bé làm tốt việc ngoài đời.  
**Acceptance Criteria:**
- Thưởng nóng: Bố mẹ có thể thưởng lẻ từ 1, 2 đến 5 Gold kèm lời nhắn động viên.
- Quà tặng thật: Khi bé đạt thành tích (nuôi xong 1 con bò), hệ thống nhắc bố mẹ tặng quà ngoài đời (đi công viên, ăn kem...). Bố mẹ nhấn "Xác nhận đã tặng" để lưu vào nhật ký thành tích của bé.

---

## US 5.3: Gift for Friends (Tặng Gold cho bạn bè/anh em)
**User Role:** Bé.  
**Nội dung:** Bé có thể chia sẻ thành quả lao động của mình cho người khác (như anh chị em trong nhà).  
**Acceptance Criteria:**
- Điều kiện: Bé phải có ít nhất 10 Gold trong ví.
- Thao tác: Bé chọn tên bạn bè/anh em trong danh sách liên kết -> Nhập số Gold muốn tặng (Tối đa 50 Gold mỗi lần để tránh việc dồn tiền quá nhanh).
- Thông điệp: Bé chọn icon cảm xúc kèm theo (Trái tim, Like, Cảm ơn).
- Ý nghĩa: Dạy bé sự sẻ chia và hào phóng.

---

## US 5.4: Gifting & Queue Logic (Logic Tặng & Xếp hàng)
**User Role:** Bé nhận quà.  
**Acceptance Criteria:**
- Kiểm tra sức chứa (Capacity Check): Trước khi tặng, hệ thống kiểm tra số Slot của người nhận. Nếu đầy, hệ thống hiện thông báo cho người tặng: "Bạn của bạn hiện hết chỗ nuôi bò, chú bê sẽ phải đợi ở cổng trang trại của họ. Bạn vẫn muốn tặng chứ?".
- Hàng đợi (The Queue): Cho phép tối đa 01 chú bê nằm trong danh sách chờ (Waiting List). Điều này tạo động lực cực lớn để bé nhận quà phải nỗ lực làm việc nhà, kiếm Gold để "giải cứu" chú bê đang đợi ngoài cổng.
- Thời gian chờ: Chú bê ở hàng rào sẽ không bị đói (không bị trừ EXP) vì nó chưa chính thức bắt đầu lộ trình 21 ngày. Lộ trình chỉ tính từ lúc bé nhấn nút "Đón vào chuồng".