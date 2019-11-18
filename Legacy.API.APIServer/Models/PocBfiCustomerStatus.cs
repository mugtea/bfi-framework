using System;
using System.Collections.Generic;

namespace Legacy.API.APIServer.Models
{
    public partial class PocBfiCustomerStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public bool? IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
