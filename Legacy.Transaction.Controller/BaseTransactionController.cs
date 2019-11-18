using BFICommon.Dataaccess;


namespace Legacy.Transaction.Controller
{
    public class BaseTransactionController
    {
        protected DatabaseService database;
        protected DatabaseService database_centerix;
        public BaseTransactionController()
        {
            database = new DatabaseService("DBConnection");
            database_centerix = new DatabaseService("DBConnection_Centerix");
        }
    }
}
