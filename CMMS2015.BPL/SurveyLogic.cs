using System;
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
    public static class SurveyLogic
    {

        public static SurveyDet GetSurveyDetail(int id)
        {
            return Survey_db.GetSurveyDetail(id);
        }

    }
}
