using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgTradeOnline.Models.Db
{
    [Table("dailypricelist")]
    public partial class dailypricelist
    {
        public int Id { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(255)]
        public string Stock { get; set; }

        public double? Open { get; set; }

        public double? High { get; set; }

        public double? Low { get; set; }

        public double? Close { get; set; }

        public double? Change { get; set; }

        public double? Deals { get; set; }

        public double? Volume { get; set; }
    }
}
