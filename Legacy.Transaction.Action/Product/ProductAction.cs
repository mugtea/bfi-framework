using BFICommon.Dataaccess;
using Legacy.Entities.Product;
using Legacy.Repository.Command.Product;


namespace Legacy.Transaction.Action.Product
{
    public class ProductAction
    {
        ProductRepositoryCommand ProductRepositoryCommand;
        public ProductAction(DatabaseService databaseService)
        {
            ProductRepositoryCommand = new ProductRepositoryCommand(databaseService);
        }


        public void InsertProduct(AddProductRequestEntities productRequestEntities)
        {
            ProductRepositoryCommand.CreateProduct(productRequestEntities);
        }
        public void UpdateProduct(EditProductRequestEntities productRequestEntities)
        {
            ProductRepositoryCommand.UpdateProduct(productRequestEntities);
        }

        public void DeleteProduct(DeleteProductRequestEntities productRequestEntities)
        {
            ProductRepositoryCommand.DeleteProduct(productRequestEntities);
        }
    }
}
