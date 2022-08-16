using System;
using System.Collections.Generic;
using DAL.EFBase;
using DTO.Customer;
using Models.Entities;

namespace DAL.Abstract
{
    public interface ICustomerRepository : IEFBaseRepository<Customer>
    {

        
    }
}