using Legacy.View.Request;

namespace Legacy.Entities.Product
{
    public class PaggingRequestEntities : BaseFilterRequestEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ExpiredDate { get; set; }
    }
    public class EditProductRequestEntities
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ExpiredDate { get; set; }
    }
    public class AddProductRequestEntities
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ExpiredDate { get; set; }
    }
    public class DeleteProductRequestEntities
    {
        public int ProductId { get; set; }
    }
}
