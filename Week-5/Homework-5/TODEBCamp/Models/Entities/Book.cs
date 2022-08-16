using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class Book
    {
        // Key attribute kullanarak Id'yi Primary Key olarak tanımlıyoruz.
        // Bu sayede yeni veri girişi olduğunda Id otomatik ve unique olarak belirlenecek
        // GenreId, AuthorId ve PublisherId'nin ForeingKey özelliği taşıdığını belirtiyoruz.
        // Bu sayede Joinler oluştururken tablolar arasında bağlantı kurabileceğiz.
        [Key]
        
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public int PublisherId { get; set;}
        public decimal Price { get; set; }

        public string Title { get; set; }
        
        [ForeignKey("GenreId")]
        public Genre Genre {get; set;}

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }


        [ForeignKey("PublisherId")]
        public Publisher Publisher {get; set;}

    }
}
