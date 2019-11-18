using System;
using System.Collections.Generic;

namespace Legacy.API.APIServer.Models
{
    public partial class PocBfiProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
