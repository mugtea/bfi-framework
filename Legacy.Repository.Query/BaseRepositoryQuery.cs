using BFICommon.Dataaccess;
using BFICommon.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Legacy.Repository.Query
{
    public abstract class BaseRepositoryQuery
    {
        protected DatabaseService Database;
        protected Type sQueries;

        protected DataSet ExecDataSet(string queryName,object param)
        {
            return Database.ExecDataSet(DatabaseUtil.ReadSQLQueriesFromResourceFile(queryName, sQueries), DatabaseUtil.ObjectToParamSP(param));
        }

        protected DataSet ExecDataSet(string queryName)
        {
            return Database.ExecDataSet(DatabaseUtil.ReadSQLQueriesFromResourceFile(queryName, sQueries));
        }
    }

}
