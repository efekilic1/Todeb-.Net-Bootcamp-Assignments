using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract;
using Businnes.Configuration.Response;
using Bussines.Configuration.HashHelper;
using DAL.Abstract;
using DTO.User;
using Models.Entities;
using FluentValidation;
using Business.Configuration.Validator.FluentValidation;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        // DAL katmanıyla bağlantımızı interface ile sağlıyoruz.
        // Mapper ile CreateUserRegisterRequest nesnesi ile User nesnesini birbirine eşleyebiliyoruz.
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;

        }



        public CommandResponse Register(CreateUserRegisterRequest register)
        {
            //// Validation
           
            var validator = new CreateUserRegisterRequestValidator();
            validator.ValidateAndThrow(register);





            byte[] passwordHash, passwordSalt;
            HashHelper.CreatePasswordHash(register.UserPassword, out passwordHash, out passwordSalt);

            var user = _mapper.Map<User>(register);

            user.Password = new UserPassword()
            {
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            _userRepository.Add(user);
            _userRepository.SaveChanges();

            return new CommandResponse()
            {
                Message = $"User registered successfully. Name:{user.Name}, Surname:{user.Surname}, Email:{user.Email}, Password:{register.UserPassword} ",
                Status = true
            };

        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }





    }
}
