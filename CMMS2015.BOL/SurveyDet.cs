using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMS2015.BOL
{
     [Serializable]
    public class SurveyDet
    {

         //public int WRNumber { get; set; }
         public int WONumber { get; set; }
       
       
        public string Comments { get; set; }
      
        public DateTime CreatedOn { get; set; }
        public int Question5Ans { get; set; }

        public int Question1Ans { get; set; }
        public int Question2Ans { get; set; }
        public int Question3Ans { get; set; }
    }
}
