using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Abstract;
using DAL.DbContexts;
using Models.Entities;

namespace DAL.Concrete
{
    public class CustomerRepository : ICostumerRepository
    {
        private BookStoreDbContext context;

        public CustomerRepository(BookStoreDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Insert(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();

        }

        public void Update(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return context.Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
