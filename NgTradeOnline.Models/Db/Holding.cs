using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgTradeOnline.Models.Db
{
    [Table("Holding")]
    public partial class Holding
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime DatePurchased { get; set; }

        public int AccountId { get; set; }

        [StringLength(100)]
        public string Symbol { get; set; }
    }
}
