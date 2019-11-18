using System;
using System.Collections.Generic;

namespace Legacy.API.APIServer.Models
{
    public partial class PocBfiLeadsInfo
    {
        public PocBfiLeadsInfo()
        {
            PocBfiCustomer = new HashSet<PocBfiCustomer>();
        }

        public string LeadsId { get; set; }
        public string Company { get; set; }
        public string Platform { get; set; }
        public string Product { get; set; }
        public string CustomerType { get; set; }
        public string LeadsStatusInternal { get; set; }
        public string Branch { get; set; }
        public string RequestType { get; set; }
        public string LeadsStatusExternal { get; set; }

        public ICollection<PocBfiCustomer> PocBfiCustomer { get; set; }
    }
}
