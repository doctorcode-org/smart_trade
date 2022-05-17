namespace SmartTrade.Models
{
    public class LoginResponse
    {
        public string AccessToken { get; set; }

        public int ExpiresIn { get; set; }

        public int OtpLifetime { get; set; }

        public int LoginForOtpLifetime { get; set; }

        public string MobileNumber { get; set; }

        public bool PasswordExpired { get; set; }

        public bool EnableTwoFactorAuthentication { get; set; }
    }
}
