using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMMS2015.BPL.Common;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using CMMS2015.DAL.Utility;

namespace CMMS2015.BPL.LookUp
{
    public class GeneralLookUp
    {
             
        public static DataSet GetProperties()
        {
            //get data from 
            return DBCommands.GetData("spn_GetProperty_59000", null);
        }


        public static DataSet GetBuildingList()
        {

            //get data from database
            return DBCommands.GetData("spn_GetBuildingList_59000", null);
        }
                

        //get work location building list by property
        public static DataSet BuildingListByProperty(string property)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            SqlParameter spProperty = new SqlParameter("@Property", property);
            sqlParams.Add(spProperty);
            //get data from database
            return DBCommands.GetData("spn_GetBuildingList_Property_59000", sqlParams);
        }

        public static DataSet GetRequesterInstitute()
        {
            //get data from database
            return DBCommands.GetData("spn_GetInstitute_59000", null);
        }  
    }
}
