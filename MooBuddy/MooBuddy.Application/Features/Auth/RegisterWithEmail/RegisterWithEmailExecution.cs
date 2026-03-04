using MooBuddy.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MooBuddy.Application.Features.Auth.RegisterWithEmail
{
    public class RegisterWithEmailExecution
    {
        private readonly MooBuddyDbContext _context;

        public RegisterWithEmailExecution(IMooBuddyDbContext context)
        {
            _context = context;
        }

        public async Task<Result<AuthResponse>> ExecuteAsync(string email, string password, string name)
        {
            // 1. Check trùng
            if (await _context.Users.AnyAsync(u => u.Email == email))
                return Result<AuthResponse>.Failure("Email đã tồn tại.");

            // 2. Tạo dữ liệu
            var family = new Family { Id = Guid.NewGuid(), FamilyCode = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper() };
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = email,
                FullName = name,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                Provider = "Email",
                Family = family
            };

            _context.Families.Add(family);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Result<AuthResponse>.Success(new AuthResponse
            {
                Token = "FAKE_TOKEN",
                FamilyCode = family.FamilyCode
            }, "Đăng ký thành công!");
        }
    }
}
