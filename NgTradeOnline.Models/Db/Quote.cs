using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgTradeOnline.Models.Db
{
    [Table("Quote")]
    public partial class Quote
    {
        public DateTime? Date { get; set; }

        public int QuoteId { get; set; }

        public decimal? Low { get; set; }

        public decimal? Open { get; set; }

        public int? Volume { get; set; }

        public decimal? Close { get; set; }

        public decimal? High { get; set; }

        [StringLength(255)]
        public string SYMBOL { get; set; }

        public decimal? CHANGE1 { get; set; }

        public int? TRADES { get; set; }
    }
}
