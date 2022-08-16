using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Abstract;
using DAL.DbContexts;
using DAL.EFBase;
using Models.Entities;

namespace DAL.Concrete
{
    public class EFCustomerRepository : EFBaseRepository<Customer, BookStoreDbContext>, ICustomerRepository
    {
        

        public EFCustomerRepository(BookStoreDbContext context):base(context)
        {
           
        }


    }
}
