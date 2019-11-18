using System;
using System.Collections.Generic;

namespace Legacy.API.APIServer.Models
{
    public partial class PocBfiCustomer
    {
        public PocBfiCustomer()
        {
            PocBfiAddressDetail = new HashSet<PocBfiAddressDetail>();
        }

        public int CustomerId { get; set; }
        public string LeadsId { get; set; }
        public int? CustomerContactId { get; set; }
        public string CustomerName { get; set; }
        public string IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime? IdentityExpiredDate { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Channel { get; set; }
        public string SourceOfLeads { get; set; }
        public string MediaPromotion { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string MotherMaidenName { get; set; }
        public string Npwpnumber { get; set; }
        public string ReferralType { get; set; }
        public string ReferralName { get; set; }

        public PocBfiCustomerContact CustomerContact { get; set; }
        public PocBfiLeadsInfo Leads { get; set; }
        public ICollection<PocBfiAddressDetail> PocBfiAddressDetail { get; set; }
    }
}
