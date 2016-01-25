using System;
using System.ComponentModel.DataAnnotations;

namespace NgTradeOnline.Models.Db
{
    public partial class News
    {
        [Key]
        public int PostId { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        public string Text { get; set; }

        public DateTime? PostDate { get; set; }
    }
}
