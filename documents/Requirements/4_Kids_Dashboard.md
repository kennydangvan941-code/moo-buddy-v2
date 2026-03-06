​US 4.1: First Appearance (Chú bò xuất hiện lần đầu)
​User Role: Bé.
​Nội dung: Sau khi bố mẹ bàn giao máy, bé thấy chú bò của mình lần đầu tiên.
​Acceptance Criteria:
​Hiển thị hoạt cảnh (Animation) chú bò con (Bê con) dễ thương chào đón bé bằng tên (Nickname bố mẹ đã đặt).
​Hiển thị lời thoại chào mừng: "Chào [Tên bé], tớ là Bò Chăm Chỉ. Hãy giúp tớ lớn lên trong 21 ngày tới nhé!".
​Giao diện trực quan: Một chiếc chuồng bò đơn giản, thanh kinh nghiệm (EXP) ở mức 0 và kho chứa cỏ đang trống.

​US 4.2: Daily Task List (Danh sách nhiệm vụ hàng ngày của bé)
​User Role: Bé.
​Nội dung: Bé xem danh sách các việc cần làm để kiếm cỏ cho bò.
​Acceptance Criteria:
​Danh sách hiển thị dưới dạng các "Cuộn giấy" hoặc "Thẻ nhiệm vụ" sinh động.
​Mỗi thẻ ghi rõ: Tên việc, Icon minh họa và số lượng Cỏ nhận được (tương ứng với độ khó bố mẹ đã giao).
​Phân loại theo buổi (Sáng/Chiều/Tối) để bé dễ theo dõi.

​US 4.3: Task Execution (Bé thực hiện nhiệm vụ)
​User Role: Bé.
​Nội dung: Bé xác nhận đã làm xong việc.
​Acceptance Criteria:
​Nút "Xong rồi!" to và nổi bật trên mỗi thẻ nhiệm vụ.
​Nếu nhiệm vụ yêu cầu ảnh: Mở camera để bé chụp ảnh minh chứng.
​Sau khi bấm, thẻ nhiệm vụ chuyển sang trạng thái "Chờ bố mẹ duyệt" (đổi màu hoặc có biểu tượng đồng hồ cát).

​US 4.4: Receiving Grass (Bé nhận cỏ sau khi hoàn thành)
​User Role: Bé.
​Nội dung: Sau khi bố mẹ nhấn "Duyệt" trên máy của họ, bé sẽ nhận được cỏ trên máy của mình.
​Acceptance Criteria:
​Thông báo (Push Notification): Một thông báo hiện lên trên màn hình chính: "Ting ting! Bố mẹ đã duyệt bài tập về nhà của bạn. Bạn nhận được [X] bó cỏ!".
​Hiệu ứng nhận cỏ: Khi bé mở App, có hiệu ứng các bó cỏ bay từ trên trời rơi vào "Kho chứa cỏ" của bé.
​Cập nhật số dư: Số lượng cỏ trong kho tăng lên ngay lập tức.

​US 4.5: Feeding the Cow (Bé cho bò ăn)
​User Role: Bé.
​Nội dung: Bé dùng cỏ đã kiếm được để cho chú bò ăn và giúp bò lớn lên.
​Acceptance Criteria:
​Thao tác Drag & Drop (Kéo thả): Bé nhấn giữ bó cỏ trong kho và kéo thả vào miệng chú bò.
​Hành động của bò: Chú bò thực hiện động tác nhai (munching) kèm âm thanh vui tai và hiện trái tim trên đầu.
​Lời thoại của bò: Bò nói lời cảm ơn: "Ngon quá, tớ cảm ơn [Tên bé]! Tớ sắp lớn thêm chút rồi nè!".

​US 4.6: Cow Evolution & Discipline Logic (Logic Tiến hóa & Kỷ luật)
​User Role: Hệ thống / Bé.
​Nội dung: Chú bò lớn lên dựa trên kỷ luật rèn luyện hàng ngày. Nếu bé lười biếng, chú bò sẽ bị sụt cân (trừ EXP).
​Acceptance Criteria (Điều kiện nghiệm thu):
​Chỉ số tăng trưởng mặc định:
​Hệ số quy đổi: 1 bó cỏ = 1.5 EXP.
​Thời gian kiểm tra (Check-point): 00:00 mỗi ngày. Nếu bò ăn mỗi bó xong thì cộng exp, nếu ko được ăn gì thì cuối ngày trừ 1.5EXP
​Giai đoạn 1: Bê con (Ngày 1 - Ngày 7)
​Mục tiêu: Ăn đủ 2 bó cỏ/ngày.
​Cơ chế Thưởng: Nếu ăn đủ, nhận 2 \times 1.5 = 3.0 EXP/ngày.
​Cơ chế Phạt (Bò đói): Nếu cuối ngày bé không cho ăn bó cỏ nào, hệ thống trừ 1.5 EXP vào tổng điểm tích lũy.
​Điều kiện lên cấp: Đạt đủ 21 EXP (Hệ thống hiện hiệu ứng tiến hóa thành Bê nhỡ).
​Giai đoạn 2: Bê nhỡ (Ngày 8 - Ngày 21)
​Mục tiêu: Ăn đủ 4 bó cỏ/ngày (Bố mẹ cần giao nhiều task hơn).
​Cơ chế Thưởng: Mỗi bó cỏ vẫn tính 1.5 EXP. Nếu ăn đủ, nhận 4 \times 1.5 = 6.0 EXP/ngày.
​Cơ chế Phạt (Bò đói): Nếu cuối ngày bé không cho ăn, hệ thống trừ 1.5 EXP vào tổng điểm tích lũy.
​Điều kiện lên cấp: Tích lũy thêm 84 EXP (Tổng cộng đạt 105 EXP). Chú bò sẽ thực hiện hoạt cảnh trưởng thành rực rỡ.
​Giai đoạn 3: Bò trưởng thành (Sau ngày 21)
​Trạng thái: Bò tự do (không bị trừ EXP nữa).
​Thành quả: Mỗi 24h, hệ thống sinh ra 01 Bịch sữa.
​Thu hoạch: Bé chạm vào bịch sữa để đổi thành Gold (Vàng). Nếu không thu hoạch, bịch sữa vẫn nằm đó.

​US 4.7: The Farm Expansion (Mở rộng trang trại - Con bê thứ 2)
​User Role: Bé.
​Nội dung: Sau khi chú bò thứ nhất trưởng thành, bé có thể bắt đầu hành trình mới với một chú bê con khác.
​Acceptance Criteria:
​Điều kiện kích hoạt: Chú bò số 1 đạt trạng thái "Trưởng thành" (Xong 21 ngày).
​Hành động: Hệ thống mở khóa nút "Đón thành viên mới".
​Cơ chế song song: * Chú bò số 1 vẫn đứng ở một góc đồng cỏ, mỗi ngày tự sản sinh 01 bịch sữa (như một nguồn thu nhập thụ động).
​Bé được tặng/mua một chú Bê con số 2 và bắt đầu lại lộ trình 21 ngày (ăn 2 cỏ/ngày, bị phạt nếu đói...).
​Mục tiêu: Bé có thể sở hữu một đàn bò (Ví dụ: Trang trại có tối đa 5 chỗ trống). Càng nhiều bò trưởng thành, lượng sữa (Gold) bé nhận được mỗi ngày càng lớn.

​US 4.8: Farm Expansion & Investment (Nâng cấp chuồng trại & Mua giống)
​User Role: Bé.
​Nội dung: Bé nhận bê con mới sau khi hoàn thành thử thách và dùng Gold để mua thêm giống hoặc nâng cấp sức chứa của chuồng.
​Acceptance Criteria (Điều kiện nghiệm thu):
​Tặng bê con lần đầu (Reward for 21 days):
​Khi chú bò số 1 đạt trạng thái "Trưởng thành" (Xong ngày 21), hệ thống hiển thị một hộp quà lớn.
​Khi bé chạm vào, hệ thống Tặng miễn phí chú Bê con số 2 để bắt đầu hành trình 21 ngày tiếp theo.
​Thông báo: "Chúc mừng nông dân nhí! Bạn đã xuất sắc nuôi lớn chú bò đầu tiên. Đây là chú bê con thứ 2 dành tặng cho sự chăm chỉ của bạn!"
​Cơ chế mua giống (Investment):
​Từ chú bê thứ 3 trở đi, hệ thống không tặng miễn phí. Bé phải vào "Cửa hàng giống" để mua.
​Giá niêm yết: 300 Gold cho mỗi chú bê con mới.
​Bé phải tích lũy đủ Gold (từ sữa của các bò trưởng thành hoặc thưởng thêm từ bố mẹ) để mua.
​Nâng cấp sức chứa chuồng trại (Upgrade Slots):
​Mặc định chuồng trại ban đầu có 02 ô đất (Slots).
​Để nuôi được con thứ 3, thứ 4... bé phải dùng Gold để "Xây thêm chuồng" (Mở khóa Slot).
​Giá nâng cấp Slot: Tăng dần theo số lượng (VD: Slot 3 là 500 Gold, Slot 4 là 1000 Gold).
​Điều này giúp tạo ra mục tiêu tiêu thụ Gold lớn, buộc bé phải làm nhiều nhiệm vụ khó hơn để kiếm tiền nâng cấp.

​US 4.9: Cow Retirement & Legacy (Nghỉ hưu và Di sản)
​User Role: Hệ thống / Bé.
​Nội dung: Sau một thời gian cống hiến sữa, chú bò sẽ nghỉ hưu để nhường chỗ cho thế hệ mới, để lại một phần thưởng kỷ niệm cho bé.
​Acceptance Criteria (Điều kiện nghiệm thu):
​Thời hạn khai thác: Mỗi chú bò sau khi trưởng thành (từ ngày 22) sẽ có thêm 40 ngày sản xuất sữa (Tổng vòng đời trong App là khoảng 60 ngày).
​Thông báo chuẩn bị: Khi còn 7 ngày cuối, hệ thống hiển thị thông báo: "Chú bò [Tên bò] đã làm việc chăm chỉ và sắp đến lúc được đi nghỉ mát tại Đảo Bò Xanh rồi!".
​Lễ nghỉ hưu (Retirement Event): * Khi hết hạn, chú bò sẽ không biến mất ngay. Bé nhấn vào nút "Cảm ơn và Nghỉ ngơi".
​Một đoạn phim ngắn (Animation) hiện ra: Chú bò đeo kính râm, xách vali và vẫy tay chào bé.
​Phần thưởng di sản (Legacy Bonus): * Chú bò để lại một "Kỷ niệm chương" hoặc một "Vật phẩm đặc biệt" (VD: Cái chuông vàng) đặt trong phòng truyền thống của trang trại.
​Bé nhận được một khoản Gold hưu trí lớn một lần duy nhất (Lump sum).
​Giải phóng chuồng (Slot): Ô đất (Slot) đó trở nên trống, bé có thể mua hoặc nhận một chú bê con mới để bắt đầu lại.
