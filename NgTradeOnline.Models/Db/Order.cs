using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgTradeOnline.Models.Db
{
    [Table("Order")]
    public partial class Order
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public DateTime? CompletionDate { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

        public DateTime? OpenDate { get; set; }

        public int AccountId { get; set; }

        [Required]
        [StringLength(250)]
        public string Symbol { get; set; }

        public int HoldingId { get; set; }
    }
}
