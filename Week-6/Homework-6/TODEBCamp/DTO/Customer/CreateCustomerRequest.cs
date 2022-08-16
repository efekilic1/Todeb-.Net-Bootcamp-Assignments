using System;
namespace DTO.Customer
{
    public class CreateCustomerRequest
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

    }
}
