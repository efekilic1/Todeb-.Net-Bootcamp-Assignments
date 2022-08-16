using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Models.Entities
{
    public class Genre
    {
        // Key attribute kullanarak Id'yi Primary Key olarak tanımlıyoruz.
        // Bu sayede yeni veri girişi olduğunda Id otomatik ve unique olarak belirlenecek
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }


    }
}
