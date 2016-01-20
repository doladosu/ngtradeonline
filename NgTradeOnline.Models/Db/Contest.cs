using System;
using System.ComponentModel.DataAnnotations;

namespace NgTradeOnline.Models.Db
{
    public partial class Contest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public long Prizes { get; set; }

        public int EntryFee { get; set; }

        public int Size { get; set; }

        public DateTime ContestDate { get; set; }
    }
}
