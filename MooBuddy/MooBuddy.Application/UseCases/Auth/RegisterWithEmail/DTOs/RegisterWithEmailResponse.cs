namespace MooBuddy.Application.UseCases.Auth.RegisterWithEmail.DTOs
{
    public class RegisterWithEmailResponse
    {
        public string Token { get; set; } = string.Empty;
        public string? FamilyCode { get; set; }
    }
}
