using BFICommon.Dataaccess;
using BFICommon.Util;
using Legacy.Database.SQLQuery.Product;
using Legacy.Entities.Product;
using System.Data;

namespace Legacy.Repository.Query.Product
{
    public class ProductRepositoryQuery
    {
        DatabaseService database;
        public ProductRepositoryQuery(DatabaseService database)
        {
            this.database = database;
        }
        public DataSet GetData(PaggingRequestEntities paggingRequestEntities)
        {
            string query = DatabaseUtil.ReadSQLQueriesFromResourceFile("GetData", typeof(ProductQuery));
            return database.ExecDataSet(query, DatabaseUtil.ObjectToParamSP(paggingRequestEntities));
        }
    }
}
