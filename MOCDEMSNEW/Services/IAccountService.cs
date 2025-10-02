namespace MOCDEMSNEW.Services
{
    public interface IAccountService
    {
        Task<string> GenerateSecretAsync(int empId);
        string GenerateQrCodeUri(string secret, string email);
        Task<bool> VerifyTwoFactorAsync(int empId, string code);
        Task EnableTwoFactorAsync(int empId);
    }
}
