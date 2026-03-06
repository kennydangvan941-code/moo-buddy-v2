public enum UserStatus
{
    Active = 1,
    Blocked = 2,    // Login sai nhiều lần
    Pending = 3,    // Chờ xác thực email
    Expired = 4     // Hết hạn gói dịch vụ
}

public enum ProfileStatus
{
    Active = 1,
    Inactive = 2,   // Bé tạm nghỉ chơi
    Suspended = 3   // Bị bố mẹ tạm khóa
}

public enum FamilyStatus
{
    Trialing = 1,   // Đang dùng thử (30 ngày đầu)
    Active = 2,     // Đã thanh toán và đang trong hạn dùng
    Expired = 3,    // Đã hết hạn, cần thanh toán để tiếp tục
    Locked = 4      // Khóa do vi phạm (tùy chọn)
}

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}

public abstract class SoftDeleteEntity : BaseEntity
{
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
}

public class User : BaseEntity
{
    public string? Email { get; set; }
    public bool EmailConfirmed { get; set; }
    public string? PasswordHash { get; set; }
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    
    // Quản lý trạng thái
    public UserStatus Status { get; set; } = UserStatus.Active;

    // Cơ chế Refresh Token
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }

    // Navigation Properties
    public virtual ICollection<UserLogin> Logins { get; set; }
    public virtual ICollection<Family> OwnedFamilies { get; set; }
    public virtual ICollection<Profile> Profiles { get; set; }
}


public class UserLogin : BaseEntity
{
    public Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual User User { get; set; }

    public string Provider { get; set; } // Google, Facebook, Apple
    public string ProviderKey { get; set; } // ID định danh từ Provider (Sub ID)
    public string? ProviderDisplayName { get; set; } // Tên hiển thị từ Provider
}

public class Family : BaseEntity
{
    public string FamilyName { get; set; }
    
    // Mã 6 ký tự để thiết bị của bé kết nối (Ví dụ: F82D10)
    public string FamilyCode { get; set; } 
    
    // Mã PIN 4 số của bố mẹ để xác thực các hành động quản trị
    public string ParentPinHash { get; set; }

    // Chủ gia đình (Người tạo)
    public Guid OwnerId { get; set; }
    [ForeignKey("OwnerId")]
    public virtual User Owner { get; set; }

    // Navigation Properties
    public virtual ICollection<Profile> Profiles { get; set; }
    public virtual ICollection<Device> Devices { get; set; }

// Ngày hết hạn dùng thử hoặc hết hạn gói đã mua
    public DateTime SubscriptionExpiryDate { get; set; } 
    
    // Đánh dấu đã từng mua gói lần nào chưa (để tránh việc xóa Family tạo lại để dùng free tiếp)
    public bool IsTrialUsed { get; set; } = true; 

    // Trạng thái tài khoản gia đình
    public FamilyStatus Status { get; set; } = FamilyStatus.Trialing;
}

public class Profile : BaseEntity
{
    public Guid FamilyId { get; set; }
    [ForeignKey("FamilyId")]
    public virtual Family Family { get; set; }

    // Link tới User nếu Profile này có tài khoản đăng nhập (Bố/Mẹ)
    public Guid? UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual User? User { get; set; }

    public string DisplayName { get; set; }
    public string? AvatarUrl { get; set; }
    
    public ProfileRole Role { get; set; }
    public ProfileStatus Status { get; set; } = ProfileStatus.Active;

    // Tài sản riêng của Profile (Nếu là Child)
    public int TotalGold { get; set; }
    public string? ChildPasscode { get; set; } // Mã PIN đơn giản riêng cho bé (nếu cần)
}
public class SubscriptionHistory : BaseEntity
{
    public Guid FamilyId { get; set; }
    [ForeignKey("FamilyId")]
    public virtual Family Family { get; set; }

    public DateTime PurchaseDate { get; set; }
    public DateTime OldExpiryDate { get; set; }
    public DateTime NewExpiryDate { get; set; }
    
    public decimal Amount { get; set; }
    public string TransactionId { get; set; } // Mã GD từ Store hoặc Bank
    public string PaymentMethod { get; set; } // ApplePay, GooglePay, Manual...
}


public enum CowStatus
{
    Normal = 1,      // Đang ở trong trang trại
    Traveling = 2,   // Đang đi du lịch (không sản sinh sữa nhưng có thể mang quà về)
    Retired = 3      // Đã nghỉ hưu
}

public class Cow : BaseEntity
{
    public Guid ProfileId { get; set; }
    public virtual Profile Profile { get; set; }

    public string Name { get; set; }
    public int Level { get; set; } = 1; // Level 1: Bê con, Level 6: Bê nhỡ...
    public decimal CurrentExp { get; set; }
    public CowStatus Status { get; set; } = CowStatus.Normal;

    // Logic đói theo ngày lịch
    public DateTime? LastFedDate { get; set; }
    public DateTime? LastCheckedDate { get; set; }

    public int TotalMilkProduced { get; set; }
    
    // Navigation
    public virtual FarmSlot? CurrentSlot { get; set; }
}

public class CowQueue : BaseEntity
{
    public Guid ProfileId { get; set; }
    public virtual Profile Profile { get; set; }

    public Guid CowId { get; set; }
    [ForeignKey("CowId")]
    public virtual Cow Cow { get; set; }

    public int Priority { get; set; } // Thứ tự ưu tiên (vào trước ra trước)
    public string Note { get; set; } // Ví dụ: "Quà tặng từ bố", "Mua từ shop"
}

public class CowTravelLog : BaseEntity
{
    public Guid CowId { get; set; }
    public virtual Cow Cow { get; set; }

    public string Destination { get; set; } // Ví dụ: "Đảo Cỏ Xanh", "Núi Tuyết"
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? GiftReceived { get; set; } // Quà bò mang về sau chuyến đi
    public int ExpGained { get; set; } // Đi du lịch cũng tăng kinh nghiệm
}


public enum TaskType
{
    Once = 1,      // Làm một lần duy nhất
    Daily = 2,     // Lặp lại hàng ngày
    Weekly = 3,    // Lặp lại hàng tuần
    Custom = 4     // Theo các thứ trong tuần được chỉ định
}

public class TaskDefinition : SoftDeleteEntity
{
    public Guid FamilyId { get; set; }
    public virtual Family Family { get; set; }

    public string Title { get; set; }
    public string? Description { get; set; }
    
    // Cấu hình thưởng
    public int GoldReward { get; set; }
    public decimal ExpReward { get; set; }

    // Cấu hình tần suất
    public TaskType Type { get; set; }
    public string? CustomDays { get; set; } // Ví dụ: "2,4,6" (Thứ 2, 4, 6)

    // Cấu hình yêu cầu
    public bool RequiresImageProof { get; set; } = true; // Bắt buộc chụp ảnh mới được duyệt
    public bool IsActive { get; set; } = true;
}

public class TaskLog : BaseEntity
{
    public Guid ProfileId { get; set; } // Bé thực hiện
    public virtual Profile Profile { get; set; }

    public Guid TaskDefinitionId { get; set; }
    public virtual TaskDefinition TaskDefinition { get; set; }

    public TaskStatus Status { get; set; } = TaskStatus.Pending;
    public string? ProofImageUrl { get; set; }
    public string? ParentNote { get; set; } // Lời nhắn của bố mẹ khi duyệt/từ chối
    public DateTime? ApprovedAt { get; set; }
    
    // Lưu lại số Gold/Exp thực tế nhận được lúc đó (đề phòng bố mẹ đổi Setting sau này)
    public int EarnedGold { get; set; }
    public decimal EarnedExp { get; set; }
}

public enum RewardStatus
{
    Available = 1,   // Đang có thể đổi
    OutOfStock = 2,  // Tạm hết (bố mẹ chưa chuẩn bị kịp)
    Hidden = 3       // Tạm ẩn
}

public class RewardSetting : SoftDeleteEntity
{
    public Guid FamilyId { get; set; }
    public virtual Family Family { get; set; }

    public string Title { get; set; }
    public string? Description { get; set; }
    public int GoldCost { get; set; } // Giá để đổi quà
    
    public string? ImageUrl { get; set; }
    public RewardStatus Status { get; set; } = RewardStatus.Available;
    
    // Giới hạn số lần đổi (ví dụ: Mỗi tuần chỉ được đổi 1 lần đi xem phim)
    public int? LimitPerWeek { get; set; }
}

public class RewardRedemption : BaseEntity
{
    public Guid ProfileId { get; set; }
    public virtual Profile Profile { get; set; }

    public Guid RewardSettingId { get; set; }
    public virtual RewardSetting RewardSetting { get; set; }

    public bool IsClaimed { get; set; } = false; // Bố mẹ đã thực hiện trao quà thực tế chưa
    public DateTime? ClaimedAt { get; set; }
    
    // Lưu lại giá Gold tại thời điểm đổi
    public int RedeemedGold { get; set; }
}

// 1. Nhật ký hoàn thành nhiệm vụ
public class TaskLog : BaseEntity
{
    public Guid ProfileId { get; set; }
    public Guid TaskDefinitionId { get; set; }
    public string TaskTitle { get; set; } // De-normalization để xem lại nhanh
    
    public int GoldReceived { get; set; }
    public int GrassReceived { get; set; }
    
    public string? ProofImageUrl { get; set; }
    public TaskStatus Status { get; set; } // Pending, Approved, Rejected
    public DateTime? ActionAt { get; set; } // Ngày bố mẹ duyệt
}

// 2. Nhật ký cho bò ăn
public class FeedingLog : BaseEntity
{
    public Guid ProfileId { get; set; }
    public Guid CowId { get; set; }
    public int Quantity { get; set; } = 1; // Số bó cỏ đã dùng
    public DateTime FedAt { get; set; } = DateTime.UtcNow;
}

// 3. Nhật ký đổi quà thực tế
public class RedemptionLog : BaseEntity
{
    public Guid ProfileId { get; set; }
    public string RewardTitle { get; set; }
    public int GoldSpent { get; set; }
    public bool IsDelivered { get; set; } // Bố mẹ đã trao quà thật chưa
}

public class TaskDailySummary : BaseEntity
{
    public Guid ProfileId { get; set; }
    public DateTime Date { get; set; } // Ngày báo cáo (VD: 2024-03-20)

    // Thống kê nhiệm vụ
    public int TotalTasksAssigned { get; set; }  // Tổng số task được giao trong ngày
    public int TotalTasksCompleted { get; set; } // Số task bé đã bấm hoàn thành
    public int TotalTasksApproved { get; set; }  // Số task bố mẹ đã duyệt thực tế

    // Thống kê tài nguyên thu nhập
    public int TotalGoldEarned { get; set; }     // Tổng Gold kiếm được trong ngày
    public int TotalGrassEarned { get; set; }    // Tổng Cỏ kiếm được trong ngày

    // Thống kê tiêu thụ (Để báo cáo sự chăm chỉ)
    public int TotalGrassFed { get; set; }       // Tổng cỏ đã cho ăn trong ngày
}


public class Notification : BaseEntity
{
    public Guid ReceiverProfileId { get; set; } // Người nhận (Bố/Mẹ hoặc Bé)
    public string Title { get; set; }
    public string Content { get; set; }
    public bool IsRead { get; set; } = false;
    public string? DeepLink { get; set; } // Bấm vào thông báo thì mở màn hình nào (VD: Màn hình duyệt Task)
    public NotificationType Type { get; set; } // TaskApproved, CowHungry, NewReward...
}

public class FamilySetting : BaseEntity
{
    public Guid FamilyId { get; set; }
    [ForeignKey("FamilyId")]
    public virtual Family Family { get; set; }

    public bool EnableHungerPenalty { get; set; } = true; // Bật/tắt phạt khi bò đói
    public int DailyTaskLimit { get; set; } = 10;        // Giới hạn số task mỗi ngày
    public string DefaultCurrencyName { get; set; } = "Gold"; 
}


