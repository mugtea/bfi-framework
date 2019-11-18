using Legacy.Entities.Product;
using Legacy.Transaction.Action.Product;
using System;

namespace Legacy.Transaction.Controller.Product
{
    public class ProductTransactionController : BaseTransactionController
    {
        ProductAction productAction;
        public ProductTransactionController()
        {
            productAction = new ProductAction(database);
        }
        public String AddProduct(AddProductRequestEntities productRequestEntities)
        {
            try
            {
                database.Connect();
                productAction.InsertProduct(productRequestEntities);
                database.Close();
                database.Dispose();
            }
            catch (Exception e)
            {
                return e.InnerException.Message.ToString();
            }

            return "Berhasil Insert";
        }
        public String UpdateProduct(EditProductRequestEntities productRequestEntities)
        {
            try
            {
                database.Connect();
                productAction.UpdateProduct(productRequestEntities);
                database.Close();
                database.Dispose();
            }
            catch (Exception e)
            {
                return e.InnerException.Message.ToString();
            }

            return "Berhasil Update";
        }
        public String DeleteProduct(DeleteProductRequestEntities productRequestEntities)
        {
            try
            {
                database.Connect();
                productAction.DeleteProduct(productRequestEntities);
                database.Close();
                database.Dispose();
            }
            catch (Exception e)
            {
                return e.InnerException.Message.ToString();
            }

            return "Berhasil Hapus";
        }
    }
}
