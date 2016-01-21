using System;

namespace NgTradeOnline.Models.Output
{
    public class Holding
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime? DatePurchased { get; set; }
        public int AccountId { get; set; }
        public string Symbol { get; set; }
    }
}