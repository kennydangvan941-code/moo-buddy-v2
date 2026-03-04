namespace MooBuddy.Domain.Enums
{
    public enum FamilyStatus
    {
        Trialing = 1,   // ?ang dùng th? (30 ngày ??u)
        Active = 2,     // ?ã thanh toán và ?ang trong h?n dùng
        Expired = 3,    // ?ã h?t h?n, c?n thanh toán ?? ti?p t?c
        Locked = 4      // Khóa do vi ph?m (tùy ch?n)
    }
}
