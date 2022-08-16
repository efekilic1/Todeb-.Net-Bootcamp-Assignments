using System;
using Business.Abstract;
using DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace API.Controllers
{
    // User Controller sınıfı ile kullanıcı oluşturabiliyoruz.

    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }



        [HttpPost("Register")]
        public IActionResult Register(CreateUserRegisterRequest register)
        {
            var response = _userService.Register(register);
            return Ok(response);

        }






    }
}