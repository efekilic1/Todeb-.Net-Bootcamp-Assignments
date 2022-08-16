using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Customer
    {
        // Key attribute kullanarak Id'yi Primary Key olarak tanımlıyoruz.
        // Bu sayede yeni veri girişi olduğunda Id otomatik ve unique olarak belirlenecek
    

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }




    }
}
