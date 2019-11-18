using BFICommon.Dataaccess;
using BFICommon.Util;
using System;

namespace Legacy.Repository.Command
{
    public abstract class BaseRepositoryCommand
    {
        protected DatabaseService Database;
        protected Type sQueries;

        protected void ExecNonQuery(string queryName, object param)
        {
            Database.ExecNonQuery(DatabaseUtil.ReadSQLQueriesFromResourceFile(queryName, sQueries), DatabaseUtil.ObjectToParamSP(param));
        }

        protected void ExecNonQuery(string queryName, Type type, object param)
        {
            Database.ExecNonQuery(DatabaseUtil.ReadSQLQueriesFromResourceFile(queryName, type), DatabaseUtil.ObjectToParamSP(param));
        }

        protected void ExecNonQuery(string queryName)
        {
            Database.ExecNonQuery(DatabaseUtil.ReadSQLQueriesFromResourceFile(queryName, sQueries));
        }
    }
}
