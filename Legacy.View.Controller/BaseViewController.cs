using BFICommon.Dataaccess;

namespace Legacy.View.Controller
{
    public class BaseViewController
    {
        protected DatabaseService database;
        protected DatabaseService database_centerix;
        public BaseViewController()
        {
            database = new DatabaseService("DBConnection");
            database_centerix = new DatabaseService("DBConnection_Centerix");
        }
    }
}
