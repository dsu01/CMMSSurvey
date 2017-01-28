using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CMMS2015.DAL.Utility;
using System.Data.SqlClient;

namespace CMMS2015.DAL.Common
{
    public static class LookupCollection_db
    {
        public static DataSet GetLookupCollectionDataSet(string storeProcedure, List<SqlParameter> sqlParams)
        {
            return DBCommands.GetData(storeProcedure, sqlParams);
        }
    }
}
