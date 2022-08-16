using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Author
    {
        // Key attribute kullanarak Id'yi Primary Key olarak tanımlıyoruz.
        // Bu sayede yeni veri girişi olduğunda Id otomatik ve unique olarak belirlenecek
        [Key] 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
