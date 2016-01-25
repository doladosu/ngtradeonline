using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgTradeOnline.Models.Db
{
    [Table("UserProfile")]
    public partial class UserProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserProfile()
        {
            webpages_Roles = new HashSet<webpages_Roles>();
        }

        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string BankName { get; set; }

        public int? AccountNumber { get; set; }

        public int? RoutingNumber { get; set; }

        [StringLength(250)]
        public string AccountType { get; set; }

        public bool? Verified { get; set; }

        public bool? BankVerified { get; set; }

        public DateTime? SignupDate { get; set; }

        [StringLength(250)]
        public string Occupation { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(250)]
        public string Address1 { get; set; }

        [StringLength(250)]
        public string Address2 { get; set; }

        [StringLength(250)]
        public string City { get; set; }

        [StringLength(250)]
        public string State { get; set; }

        [StringLength(250)]
        public string Country { get; set; }

        [StringLength(250)]
        public string PostalCode { get; set; }

        [StringLength(250)]
        public string Phone1 { get; set; }

        [StringLength(250)]
        public string Phone2 { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Question { get; set; }

        [StringLength(250)]
        public string Answer { get; set; }

        public decimal? Balance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}
