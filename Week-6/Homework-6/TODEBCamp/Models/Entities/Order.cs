using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models.Entities
{
    public class Order
    {
        // Key attribute kullanarak Id'yi Primary Key olarak tanımlıyoruz.
        // Bu sayede yeni veri girişi olduğunda Id otomatik ve unique olarak belirlenecek
        // OrderDetailId ve CustomerId'nin ForeingKey özelliği taşıdığını belirtiyoruz.
        // Bu sayede Joinler oluştururken tablolar arasında bağlantı kurabileceğiz.
        [Key]
        public int Id { get; set; }
        public int OrderDetailId { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("OrderDetailId")]
        public OrderDetail OrderDetail { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        
       
        


    }
}
