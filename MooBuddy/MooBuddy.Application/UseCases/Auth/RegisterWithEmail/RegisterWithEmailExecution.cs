using MooBuddy.Application.Common.Interfaces;
using MooBuddy.Application.Common.Models;
using MooBuddy.Application.UseCases.Auth.RegisterWithEmail.DTOs;
using MooBuddy.Domain.Entities;

namespace MooBuddy.Application.UseCases.Auth.RegisterWithEmail
{
    public class RegisterWithEmailExecution
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegisterWithEmailExecution(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<RegisterWithEmailResponse>> ExecuteAsync(RegisterWithEmailRequest request)
        {
            // 1. Check trùng
            if (await _unitOfWork.Users.AnyAsync(u => u.Email == request.Email))
                return Result<RegisterWithEmailResponse>.Failure("Email đã tồn tại.");

            // 2. Tạo dữ liệu
            var family = new Family
            {
                Id = Guid.NewGuid(),
                FamilyCode = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper()
            };
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = request.Email,
                FullName = request.FullName,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Family = family
            };

            _unitOfWork.Families.Add(family);
            _unitOfWork.Users.Add(user);
            await _unitOfWork.SaveChangesAsync();

            return Result<RegisterWithEmailResponse>.Success(new RegisterWithEmailResponse
            {
                Token = "FAKE_TOKEN",
                FamilyCode = family.FamilyCode
            }, "Đăng ký thành công!");
        }
    }
}