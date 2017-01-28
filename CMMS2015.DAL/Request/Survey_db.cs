using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CMMS2015.DAL.Utility;
using CMMS2015.BOL;
using CMMS2015.BOL.Common;

namespace CMMS2015.DAL
{
    public static class Survey_db
    {
        public static SurveyDet GetSurveyDetail(int wrid)
        {
            SurveyDet det = null;
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@WRNumber", (Object)wrid));
            DataSet ds = DBCommands.GetData("spn_GetSurvey_2_customersurvey", sqlParams);
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //populate wr fieds
                det = new SurveyDet();
                DataRow row = ds.Tables[0].Rows[0];
                //det.WRNumber = Convert.ToInt32(row["WRnumber"].ToString());
                det.WONumber = Convert.ToInt32(row["WOnumber"].ToString());
                det.CreatedOn = Convert.ToDateTime(row["DateTime"].ToString());
                //if (row["RequesterPhone"].ToString() != "")
                //{ det.RequesterPhone = row["RequesterPhone"].ToString(); }
                ////det.CreatedOn = Convert.ToDateTime(row["CreatedOn"].ToString());
                //det.RequestedOn = Convert.ToDateTime(row["Requested"].ToString());
                //det.RequestedBy = row["RequestedBy"].ToString();
              
                //if (row["Shop"].ToString() != "")
                //{ det.Shop = row["Shop"].ToString(); }
                //if (row["Status"].ToString() != "")
                //{ det.Status = row["Status"].ToString(); }

                //if (row["Descriptions"].ToString() != "")
                //{ det.Description = row["Descriptions"].ToString(); }
                //if (row["Building"].ToString() != "")
                //{ det.Building = row["Building"].ToString(); }
                //if (row["Property"].ToString() != "")
                //{ det.Property = row["Property"].ToString(); }


                //if (row["Room"].ToString() != "")
                //{ det.Room = row["Room"].ToString(); }


                if (row["Comments"].ToString() != "")
                { det.Comments = row["Comments"].ToString(); }
                det.Question5Ans = Convert.ToInt32(row["Question5"].ToString());
                if (row["Question1"].ToString() != "")
                { det.Question1Ans = Convert.ToInt32(row["Question1"].ToString()); }
                if (row["Question2"].ToString() != "")
                { det.Question2Ans = Convert.ToInt32(row["Question2"].ToString()); }
                if (row["Question3"].ToString() != "")
                { det.Question3Ans = Convert.ToInt32(row["Question3"].ToString()); }
               


            }

            return det;
        }
    }
}
