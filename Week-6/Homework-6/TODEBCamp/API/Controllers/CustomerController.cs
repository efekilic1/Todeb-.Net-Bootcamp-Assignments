using Businnes.Abstract;
using DTO.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    // CustomerController sınıfını [Authorize] attribute'u ile korumaya aldık ve yetkisiz erişimleri engelledik.

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.GetAll();
            return Ok(data);

        }
        [HttpPost]
        public IActionResult Post(CreateCustomerRequest customer)
        {
            var response = _service.Insert(customer);
            return Ok(response);

        }
        [HttpPut]
        public IActionResult Update(UpdateCustomerRequest customer)
        {
            var response = _service.Update(customer);
            return Ok(response);

        }
        [HttpDelete]
        public IActionResult Delete(DeleteCustomerRequest customer)
        {
            var response = _service.Delete(customer);
            return Ok(response);

        }

    }
}
