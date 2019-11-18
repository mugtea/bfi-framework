using BFICommon.Dataaccess;
using BFICommon.Util;
using Legacy.Entities.Product;
using Legacy.Repository.Query.Product;
using System.Collections.Generic;
using System.Data;

namespace Legacy.View.Enricher.Product
{
    public class ProductEnricher
    {
        ProductRepositoryQuery ProductRepositoryQuery;
        public ProductEnricher(DatabaseService databaseService) {
            ProductRepositoryQuery = new ProductRepositoryQuery(databaseService);
        }
        public List<ProductResponseEntities> GetAllProduct(PaggingRequestEntities productRequestEntities) {
            productRequestEntities.SearchByText = productRequestEntities.SearchByText == null ? "" : productRequestEntities.SearchByText;
            productRequestEntities.SearchByValue = productRequestEntities.SearchByValue == null ? "" : productRequestEntities.SearchByValue;
            DataSet dataset = ProductRepositoryQuery.GetData(productRequestEntities);
            return dataset.Tables[0].DataTableToListObject<ProductResponseEntities>();
        }
    }
}
