using System;

namespace Legacy.Entities.Product
{
    public class ProductResponseEntities
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ExpiredDate { get; set; }
    }
}
