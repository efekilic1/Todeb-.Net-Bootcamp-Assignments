using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Abstract;
using DAL.DbContexts;
using DAL.EFBase;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DAL.Concrete.EF
{
    public class EFUserRepository : EFBaseRepository<User, BookStoreDbContext>, IUserRepository
    {
        public EFUserRepository(BookStoreDbContext context) : base(context)
        {
        }

        public User GetUserWithPassword(string email)
        {
            return Context.Users
                .Include(x => x.Password)
                .FirstOrDefault(x => x.Email == email);
        }
    }
}
