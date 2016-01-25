using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgTradeOnline.Models.Db
{
    [Table("MailingList")]
    public partial class MailingList
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Email { get; set; }

        public DateTime DateAdded { get; set; }

        public bool Subscribed { get; set; }
    }
}
