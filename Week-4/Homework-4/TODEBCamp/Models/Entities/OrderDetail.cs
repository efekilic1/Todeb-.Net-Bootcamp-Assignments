using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models.Entities
{
    public class OrderDetail
    {
        // Key attribute kullanarak Id'yi Primary Key olarak tanımlıyoruz.
        // Bu sayede yeni veri girişi olduğunda Id otomatik ve unique olarak belirlenecek
        // BookId'nin ForeingKey özelliği taşıdığını belirtiyoruz.
        // Bu sayede Joinler oluştururken tablolar arasında bağlantı kurabileceğiz.
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }


        public ICollection<Order> Orders { get; set; }


    }
}
