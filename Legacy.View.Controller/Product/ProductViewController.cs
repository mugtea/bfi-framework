using Legacy.Entities.Product;
using Legacy.View.Enricher.Product;
using System.Collections.Generic;

namespace Legacy.View.Controller.Product
{
    public class ProductViewController : BaseViewController
    {
        ProductEnricher productEnricher;
        public ProductViewController()
        {
            productEnricher = new ProductEnricher(database);
        }
        public List<ProductResponseEntities> GetProduct(PaggingRequestEntities productRequestEntities)
        {
            database.Connect();
            List<ProductResponseEntities> data = productEnricher.GetAllProduct(productRequestEntities);
            database.Close();
            database.Dispose();
            return data;
        }
    }
}
