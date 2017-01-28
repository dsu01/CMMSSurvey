using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CMMS2015.DAL.Utility;
using CMMS2015.BOL;
using CMMS2015.BOL.Common;
//using System.Transactions;

namespace CMMS2015.DAL
{
    public static class Request_db
    {
        //public static DataSet GetRequests(string constructionNum, string phone, string asset, string nedic)
        //{
        //    RequestDet req = null;
        //    List<SqlParameter> sqlParams = new List<SqlParameter>();
        //    sqlParams.Add(new SqlParameter("@ConstructionNo", (string.IsNullOrEmpty(constructionNum)) ? DBNull.Value : (Object)constructionNum));
        //    sqlParams.Add(new SqlParameter("@Phone", (string.IsNullOrEmpty(phone)) ? DBNull.Value : (Object)phone));
        //    sqlParams.Add(new SqlParameter("@Asset", (string.IsNullOrEmpty(asset)) ? DBNull.Value : (Object)asset));
        //    sqlParams.Add(new SqlParameter("@ned_ic_abbreviation", (string.IsNullOrEmpty(nedic)) ? DBNull.Value : (Object)nedic));
        //    return DBCommands.GetData("spn_GetCP_59000", sqlParams);
        //}

        public static RequestDet GetRequestDetail(int id)
        {
            RequestDet req = null;
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@WRNumber", (Object)id));
            DataSet ds = DBCommands.GetData("spn_GetWR_WO_customersurvey", sqlParams);
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //populate wr fieds
                req = new RequestDet();
                           
                DataRow row = ds.Tables[0].Rows[0];
              
              
                req.RequestedOn = Convert.ToDateTime(row["Requested"].ToString());
                req.RequestedBy = row["RequestedBy"].ToString();
                if (row["Comments"].ToString() != "")
                { req.Comments = row["Comments"].ToString(); }
              
                if (row["Descriptions"].ToString() != "")
                { req.Description = row["Descriptions"].ToString(); }
                if (row["Building"].ToString() != "")
                { req.Building = row["Building"].ToString(); }
                 

                if (row["Room"].ToString() != "")
                { req.RequesterRoom = row["Room"].ToString(); }
                if (row["RequesterPhone"].ToString() != "")
                { req.RequesterPhone = row["RequesterPhone"].ToString(); }
               
             
            }

            return req;
        }

        public static RequestDet GetSurveyRequestDetail(int id)
        {
            RequestDet req = null;
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@WRNumber", (Object)id));
            DataSet ds = DBCommands.GetData("spn_GetSurvey_1_customersurvey", sqlParams);
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //populate wr fieds
                req = new RequestDet();

                DataRow row = ds.Tables[0].Rows[0];

                req.WONumber = Convert.ToInt32(row["WOnumber"].ToString());
                req.RequestedOn = Convert.ToDateTime(row["Requested"].ToString());
                req.RequestedBy = row["RequestedBy"].ToString();
                if (row["Comments"].ToString() != "")
                { req.Comments = row["Comments"].ToString(); }            
                if (row["Descriptions"].ToString() != "")
                { req.Description = row["Descriptions"].ToString(); }
                if (row["Building"].ToString() != "")
                { req.Building = row["Building"].ToString(); }
                if (row["Shop"].ToString() != "")
                { req.Shop = row["Shop"].ToString(); }
                if (row["Property"].ToString() != "")
                { req.Property = row["Property"].ToString(); }
                if (row["Status"].ToString() != "")
                { req.Status = row["Status"].ToString(); }
                
                if (row["Room"].ToString() != "")
                { req.RequesterRoom = row["Room"].ToString(); }
                if (row["RequesterPhone"].ToString() != "")
                { req.RequesterPhone = row["RequesterPhone"].ToString(); }


            }

            return req;
        }
        public static RequestDet GetSurveyDetail(int id)
        {
            RequestDet req = null;
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@WRNumber", (Object)id));
            DataSet ds = DBCommands.GetData("spn_GetWR_WO_customersurvey", sqlParams);
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //populate wr fieds
                req = new RequestDet();

                DataRow row = ds.Tables[0].Rows[0];

                //req.WONumber = Convert.ToInt32(row["WOnumber"].ToString());
                req.RequestedOn = Convert.ToDateTime(row["Requested"].ToString());
                req.RequestedBy = row["RequestedBy"].ToString();
                if (row["Comments"].ToString() != "")
                { req.Comments = row["Comments"].ToString(); }
                //if (row["Shop"].ToString() != "")
                //{ req.Shop = row["Shop"].ToString(); }
                if (row["Descriptions"].ToString() != "")
                { req.Description = row["Descriptions"].ToString(); }
                if (row["Building"].ToString() != "")
                { req.Building = row["Building"].ToString(); }
                //if (row["Property"].ToString() != "")
                //{ req.Property = row["Property"].ToString(); }
                //if (row["Status"].ToString() != "")
                //{ req.Status = row["Status"].ToString(); }

                //if (row["WorkBuilding"].ToString() != "")
                //{ req.Asset = row["WorkBuilding"].ToString(); }
                //if (row["WorkLocation"].ToString() != "")
                //{ req.AssetLocation = row["WorkLocation"].ToString(); }


                if (row["Room"].ToString() != "")
                { req.RequesterRoom = row["Room"].ToString(); }
                if (row["RequesterPhone"].ToString() != "")
                { req.RequesterPhone = row["RequesterPhone"].ToString(); }


            }

            return req;
        }

        public static ValidationResult AddSurveyDetails(string reqby, string reqphone, string comments, int wrnumber, int Question1Ans, int Question2Ans, int Question3Ans, int Question5Ans)
        {

            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@WRNumber", (Object)wrnumber));
            sqlParams.Add(new SqlParameter("@Question1Ans", Question1Ans < 0 ? DBNull.Value : (Object)Question1Ans));
            sqlParams.Add(new SqlParameter("@Question2Ans", Question2Ans < 0 ? DBNull.Value : (Object)Question2Ans));
            sqlParams.Add(new SqlParameter("@Question3Ans", Question3Ans < 0 ? DBNull.Value : (Object)Question3Ans));
            sqlParams.Add(new SqlParameter("@Question5Ans", Question5Ans < 0 ? DBNull.Value : (Object)Question5Ans));
            sqlParams.Add(new SqlParameter("@RequestedBy", reqby));
            sqlParams.Add(new SqlParameter("@RequesterPhone", (string.IsNullOrEmpty(reqphone)) ? DBNull.Value : (Object)reqphone));
            sqlParams.Add(new SqlParameter("@Comments", (string.IsNullOrEmpty(comments)) ? DBNull.Value : (Object)comments));


            //SqlParameter outNewWOnum = new SqlParameter("@Res", SqlDbType.Int);
            //outNewWOnum.Direction = ParameterDirection.Output;
            //sqlParams.Add(outNewWOnum);


            ValidationResult vr = DBCommands.ExecuteNonQueryWithResReturn("spn_AddResponse_CustomerSurvey", sqlParams);

            //if (vr.Success)
            //{
            //    //if no error, update id               
            //    details.WONumber = Convert.ToInt32(outNewWOnum.Value);
            //    details.ConstructionNum = outConstructionNum.Value.ToString();
            //}
            return vr;

        }

    
    }
}
