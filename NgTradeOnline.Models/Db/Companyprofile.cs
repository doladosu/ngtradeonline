using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgTradeOnline.Models.Db
{
    [Table("Companyprofile")]
    public partial class Companyprofile
    {
        [Key]
        public string Symbol { get; set; }

        public string SymbolName { get; set; }

        public string SectorCode { get; set; }

        public string RegCode { get; set; }

        public string IsnCode { get; set; }

        public DateTime? ListingDate { get; set; }

        public string Category { get; set; }

        public DateTime? AccountYearEnd { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string MAddress1 { get; set; }

        public string MAddress2 { get; set; }

        public string MCity { get; set; }

        public string MState { get; set; }

        public string MCountry { get; set; }

        public string MPostalCode { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }

        public string Fax { get; set; }

        public string Telex { get; set; }

        public string Email { get; set; }

        public string Secretary { get; set; }

        public string Website { get; set; }

        public string CInfo { get; set; }
    }
}
