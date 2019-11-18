using System;
using System.Collections.Generic;

namespace Legacy.API.APIServer.Models
{
    public partial class PocBfiCustomerContact
    {
        public PocBfiCustomerContact()
        {
            PocBfiCustomer = new HashSet<PocBfiCustomer>();
        }

        public int CustomerContactId { get; set; }
        public string ContactType { get; set; }
        public string CodeArea { get; set; }
        public string Value { get; set; }
        public bool? IsDefault { get; set; }

        public ICollection<PocBfiCustomer> PocBfiCustomer { get; set; }
    }
}
