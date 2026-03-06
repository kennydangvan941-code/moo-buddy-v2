namespace MooBuddy.Application.UseCases.Auth.RegisterWithEmail.DTOs
{
    public class RegisterWithEmailRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
    }
}