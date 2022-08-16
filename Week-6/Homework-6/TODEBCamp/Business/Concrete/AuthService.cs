using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bussines.Abstract;
using Business.Configuration.Auth;
using DAL.Abstract;
using Microsoft.Extensions.Configuration;
using Businnes.Configuration.Response;
using Bussines.Configuration.HashHelper;
using Business.Concrete;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Bussines.Concrete
{
    public class AuthService : IAuthService
    {
        // DAL katmanıyla bağlantımızı interface ile sağlıyoruz.
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public AuthService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public CommandResponse VerifyPassword(string email, string password)
        {

            var user = _userRepository.GetUserWithPassword(email);


            if (HashHelper.VerifyPasswordHash(password, user.Password.PasswordHash, user.Password.PasswordSalt))
            {

                // Şifrenin doğru olup olmadığını kontrol ediyoruz.
                return new CommandResponse()
                {
                    Status = true,
                    Message = "Password is True"
                };
            }

            return new CommandResponse()
            {
                Status = false,
                Message = "Password is False "
            };

        }
        // Token sayesinde yetkilendirme işlemlerimizi gerçekleştirebiliyoruz.
        public AccessToken Login(string email, string password)
        {
            var verifypassword = VerifyPassword(email, password);

            var user = _userRepository.Get(x => x.Email == email);

            if (verifypassword.Status)
            {
                var tokenOptions = _configuration.GetSection("TokenOptions").Get<TokenOption>();

                var expireDate = DateTime.Now.AddMinutes(tokenOptions.AccessTokenExpiration);
                var claims = new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.GivenName, user.Name),
                    new Claim(ClaimTypes.Role,user.Role.ToString())
                };

                SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey));
                var jwtToken = new JwtSecurityToken(
                    issuer: tokenOptions.Issuer,
                    audience: tokenOptions.Audience,
                    claims: claims,
                    expires: expireDate,
                    signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
                );

                var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

                return new AccessToken()
                {
                    Token = token,
                    ExpireDate = expireDate
                };
            }

            return new AccessToken()
            {

            };
        }
    }
}