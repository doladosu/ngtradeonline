using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgTradeOnline.Models.Db
{
    [Table("AccountProfile")]
    public partial class AccountProfile
    {
        [Key]
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BankName { get; set; }

        public string AccountNumber { get; set; }

        public string RoutingNumber { get; set; }

        public string AccountType { get; set; }

        public bool? Verified { get; set; }

        public bool? BankVerified { get; set; }

        public DateTime? SignupDate { get; set; }

        public string Occupation { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string NAddress1 { get; set; }

        public string NAddress2 { get; set; }

        public string NCity { get; set; }

        public string NState { get; set; }

        public string NCountry { get; set; }

        public string NPostalCode { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }

        public string Fax { get; set; }

        public string Telex { get; set; }

        public string Email { get; set; }

        public string NextOfKin { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
