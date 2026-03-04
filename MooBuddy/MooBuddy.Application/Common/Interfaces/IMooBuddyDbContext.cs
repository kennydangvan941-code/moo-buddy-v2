using MooBuddy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MooBuddy.Application.Common.Interfaces
{
    public interface IMooBuddyDbContext
    {
        // 1. Danh sách các bảng (DbSet) mà Application cần truy vấn
        DbSet<User> Users { get; set; }
        DbSet<Family> Families { get; set; }
        // Sau này bạn thêm Cow, Task, v.v. thì cũng khai báo thêm ở đây

        // 2. Phương thức lưu thay đổi (Async)
        // Cần thiết để sau khi Add User, bạn có thể lưu xuống DB
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        // 3. Truy cập vào Database Facade
        // Cực kỳ quan trọng để bạn có thể dùng Transaction (BeginTransactionAsync)
        // trong các lớp Execution khi cần thực hiện nhiều lệnh cùng lúc.
        DatabaseFacade Database { get; }
    }
}
