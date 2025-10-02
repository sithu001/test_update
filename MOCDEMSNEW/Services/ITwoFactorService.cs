namespace MOCDEMSNEW.Services
{
    public interface ITwoFactorService
    {

        string GenerateSecret();

        string GenerateQrCodeUri(string secret, string email, string issuer = "DEMS");

        bool ValidateCode(string secret, string code);

    }
}
