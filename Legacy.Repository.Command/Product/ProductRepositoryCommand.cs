using BFICommon.Dataaccess;
using BFICommon.Util;
using Legacy.Database.SQLQuery.Product;
using Legacy.Entities.Product;
using System.Data;

namespace Legacy.Repository.Command.Product
{
    public class ProductRepositoryCommand
    {
        DatabaseService database;
        public ProductRepositoryCommand(DatabaseService database)
        {
            this.database = database;
        }
        public DataSet CreateProduct(AddProductRequestEntities productRequestEntities)
        {
            string query = DatabaseUtil.ReadSQLQueriesFromResourceFile("Insert", typeof(ProductQuery));
            return database.ExecDataSet(query, DatabaseUtil.ObjectToParamSP(productRequestEntities));
        }
        public void UpdateProduct(EditProductRequestEntities productRequestEntities)
        {
            string query = DatabaseUtil.ReadSQLQueriesFromResourceFile("Update", typeof(ProductQuery));
           database.ExecNonQuery(query, DatabaseUtil.ObjectToParamSP(productRequestEntities));
        }
        public void DeleteProduct(DeleteProductRequestEntities productRequestEntities)
        {
            string query = DatabaseUtil.ReadSQLQueriesFromResourceFile("Delete", typeof(ProductQuery));
            database.ExecNonQuery(query, DatabaseUtil.ObjectToParamSP(productRequestEntities));
        }
    }
}
