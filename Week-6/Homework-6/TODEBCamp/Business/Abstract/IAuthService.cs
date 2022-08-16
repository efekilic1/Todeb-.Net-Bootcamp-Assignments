using Business.Configuration.Auth;
using Businnes.Configuration.Response;


namespace Bussines.Abstract
{
    public interface IAuthService
    {
        CommandResponse VerifyPassword(string email, string password);
        AccessToken Login(string email, string password);
    }
}