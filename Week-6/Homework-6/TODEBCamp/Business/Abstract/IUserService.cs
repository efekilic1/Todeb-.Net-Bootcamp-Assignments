using Businnes.Configuration.Response;
using DTO.User;

namespace Business.Abstract
{
    public interface IUserService
    {
         CommandResponse Register(CreateUserRegisterRequest register);
    }
}
