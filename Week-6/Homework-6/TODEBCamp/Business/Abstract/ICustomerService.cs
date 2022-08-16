using System;
using System.Collections.Generic;
using Businnes.Configuration.Response;
using DTO.Customer;
using Models.Entities;

namespace Businnes.Abstract
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetAll();
        public CommandResponse Insert(CreateCustomerRequest request);
        public CommandResponse Update(UpdateCustomerRequest request);
        public CommandResponse Delete(DeleteCustomerRequest request);


    }
}
