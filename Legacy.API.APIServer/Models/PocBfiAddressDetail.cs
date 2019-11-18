using System;
using System.Collections.Generic;

namespace Legacy.API.APIServer.Models
{
    public partial class PocBfiAddressDetail
    {
        public int AddressId { get; set; }
        public int? CustomerId { get; set; }
        public string HouseStatus { get; set; }
        public string Address { get; set; }
        public string Rt { get; set; }
        public string Rw { get; set; }
        public string Province { get; set; }
        public string CityKabupaten { get; set; }
        public string Kecamatan { get; set; }
        public string Kelurahan { get; set; }
        public string ZipCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public PocBfiCustomer Customer { get; set; }
    }
}
