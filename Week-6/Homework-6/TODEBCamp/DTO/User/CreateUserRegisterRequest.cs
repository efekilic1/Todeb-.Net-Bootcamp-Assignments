using System;
using Models.Entities;


namespace DTO.User
{
    public class CreateUserRegisterRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }

        
    }
}
