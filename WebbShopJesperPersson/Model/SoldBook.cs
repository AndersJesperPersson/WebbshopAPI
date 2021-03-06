using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebbShopJesperPersson.Model
{
    public class SoldBook
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime PurchasedDate { get; set; }
        public BookCategory Category { get; set; }
        public User User { get; set; }
        
    }
}
