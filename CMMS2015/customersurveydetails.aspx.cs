using CMMS2015.BOL;
using CMMS2015.BPL;
using System;
using System.Web.UI;

namespace CMMS2015.Survey
{
    public partial class SurveyDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int wrID = ((Request.QueryString["wonumber"] == null) || (Request.QueryString["wonumber"] == "")) ? -1 : Int32.Parse(Request.QueryString["wonumber"]);

            if (!Page.IsPostBack)
            {              
               if(wrID > 0)
               {
                   RequestDet rdet = RequestLogic.GetRequestDetail(wrID);

                   if (rdet != null)
                   {
                       lbNoRequestMessage.Text = string.Empty;
                       lbWRNumber.Text = wrID.ToString();
                       lbDescription.Text = rdet.Description;
                       lbBuilding.Text = rdet.RequesterBuilding;
                       lbRoom.Text = rdet.RequesterRoom;
                       lbRequestedOn.Text = rdet.RequestedOn.ToString();
                       lbRequestedBy.Text = rdet.RequestedBy;
                       lbShop.Text = rdet.RequestedBy;
                       lbStatus.Text = rdet.Status;
                       lbReqComments.Text = rdet.Comments;
                       lbCustomerName.Text = rdet.RequestedBy;
                       lbCustomerPhone.Text = rdet.RequesterPhone;
                   }
                   else
                   { lbNoRequestMessage.Text = "No service request information."; }

                   SurveyDet sdet = SurveyLogic.GetSurveyDetail(wrID);
                   if (sdet != null)
                   {
                       lbNoSurveyMessage.Text = string.Empty;
                       lbWONumber.Text = sdet.WONumber.ToString();
                       lbCreatedOn.Text = sdet.CreatedOn.ToString();
                   
                       lbQuestion5Ans.Text = sdet.Question5Ans.ToString();

                       lbQuestion1Ans.Text = sdet.Question1Ans.ToString();
                       lbQuestion2Ans.Text = sdet.Question2Ans.ToString();
                       lbQuestion3Ans.Text = sdet.Question3Ans.ToString();
                       lbComments.Text = sdet.Comments;
                   }
                   else
                   { lbNoSurveyMessage.Text = "No survey response found."; }
               }
            }
        }
    }
}