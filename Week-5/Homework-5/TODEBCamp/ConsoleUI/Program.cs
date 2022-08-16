using System;
using DAL.DbContexts;
using Models.Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var conn = new BookStoreDbContext())
            {
                // Deneme amacıyla her tabloma 1 örnek satır ekledim.
                // Sorun olmadan çalıştı. Değelerler tabloya eklendi.

                /*  var gen = new Genre
                  {
                      Name = "Art"
                  }; */
                /* var aut = new Author
                 {
                     FirstName ="Frank",
                     LastName = "Herbert"
                 }; */
                /* var cus = new Customer
                 {
                     FirstName = "Merve",
                     LastName = "Demir",
                     PhoneNumber = "3454987122",
                     Address = "8522 sokak no: 41 Demir Apartmanı Kat:2 Daire: 6",
                     City ="İstanbul"
                 }; */
                /*  var pub = new Publisher
                  {
                      Id=1,
                      Name = "YKY"
                  }; */
                var _book = new Book
                {
                    AuthorId = 1,
                    PublisherId = 1,
                    GenreId =1,
                    PageCount = 800,
                    Title = "Dune",
                    Price = 35
                };
                 
                conn.Books.Add(_book);
                conn.SaveChanges();
            }
        }
    }
}
