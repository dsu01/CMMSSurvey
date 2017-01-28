using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMMS2015.BOL.Common;
using CMMS2015.BOL;
using System.Data;
using CMMS2015.DAL;

namespace CMMS2015.BPL
{    
    public static class RequestLogic
    {
        //if other people aleady update
        public static ValidationResult AddSurveyDetails(string reqby, string reqphone, string comments, int wrnumber, int Question1Ans, int Question2Ans, int Question3Ans, int Question5Ans)
        {
            return Request_db.AddSurveyDetails(reqby, reqphone,comments,wrnumber, Question1Ans,Question2Ans,Question3Ans,Question5Ans);
        }

        public static RequestDet GetRequestDetail(int id)
        {
            return Request_db.GetRequestDetail(id);
        }

        public static RequestDet GetSurveyRequestDetail(int id)
        {
            return Request_db.GetSurveyRequestDetail(id);
        }
 
    }
}
