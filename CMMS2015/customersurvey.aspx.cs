using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMMS2015.BOL;
using CMMS2015.BPL;
using CMMS2015.BOL.Common;

namespace CMMS2015.Survey
{
    public partial class SurveyEntryForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                int wrID = ((Request.QueryString["wonumber"] == null) || (Request.QueryString["wonumber"] == "")) ? -1 : Int32.Parse(Request.QueryString["wonumber"]);
              
                if (!Page.IsPostBack)
                {
                    if (wrID > 0)
                    {
                        btnSubmit.Visible = true;
                        LoadWRDetail(wrID); 
                    
                    }
                    else
                    {
                        btnSubmit.Visible = false;
                    }
                   
                }   
            }
        }
        private void LoadWRDetail(int wrId)
        {
            //Descriptions, RequestedBy, RequesterPhone, Property, Building, Room, Requested, WOnumber, Shop, Status, Comments
            RequestDet wrdet = RequestLogic.GetRequestDetail(wrId);
            lbWRnumber.Text = wrId.ToString();
            if (wrdet != null)
            {                
                //#region "Display Read Only WR Info"
                lbRequestedOn.Text = wrdet.RequestedOn.ToShortDateString();
                lbBuilding.Text = wrdet.Building;
                lbRoom.Text = wrdet.RequesterRoom;
                lbName.Text = wrdet.RequestedBy;
                lbPhone.Text = wrdet.RequesterPhone;
                lbComments.Text = wrdet.Comments;
                lbDescription.Text = wrdet.Description;

            }
        }

        private void clearText()
        {
            txtComments.Text = string.Empty;
            rdbtnQ1DisStrongly.Checked = false;
            rdbtnQ2DisStrongly.Checked = false;
            rdbtnQ3DisStrongly.Checked = false;
            rdbtnQ5DisStrongly.Checked = false;

            rdbtnQ1Dis.Checked = false;
            rdbtnQ2Dis.Checked = false;
            rdbtnQ3Dis.Checked = false;
            rdbtnQ5Dis.Checked = false;

            rdbtnQ1Neutral.Checked = false;
            rdbtnQ2Neutral.Checked = false;
            rdbtnQ3Neutral.Checked = false;
            rdbtnQ5Neutral.Checked = false;

            rdbtnQ1AgreeStrongly.Checked = false;
            rdbtnQ2AgreeStrongly.Checked = false;
            rdbtnQ3AgreeStrongly.Checked = false;
            rdbtnQ5AgreeStrongly.Checked = false;

            rdbtnQ1Agree.Checked = false;
            rdbtnQ2Agree.Checked = false;
            rdbtnQ3Agree.Checked = false;
            rdbtnQ5Agree.Checked = false;

            lbMessage.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strReqBy = Server.HtmlEncode(lbName.Text.Trim());
            string strReqPhone = Server.HtmlEncode(lbPhone.Text.Trim());
            string strComments = Server.HtmlEncode(txtComments.Text.Trim());
            string wrnumber = Server.HtmlEncode(lbWRnumber.Text.Trim());         

            if (rdbtnQ5DisStrongly.Checked || rdbtnQ5Dis.Checked || rdbtnQ5Neutral.Checked || rdbtnQ5AgreeStrongly.Checked || rdbtnQ5Agree.Checked)
            {
                 #region "get answer number"
                   int Question5Ans = 0;
                    //1 meaning most unsatisfied and 5 is the most satisfied
                   if (rdbtnQ5DisStrongly.Checked)
                        Question5Ans = 1;
                   else if (rdbtnQ5Dis.Checked)
                        Question5Ans = 2;
                   else if (rdbtnQ5Neutral.Checked)
                        Question5Ans = 3;
                   else if (rdbtnQ5Agree.Checked)
                        Question5Ans = 4;
                   else if (rdbtnQ5AgreeStrongly.Checked)
                        Question5Ans = 5;
                 int Question1Ans = 0;
                    //1 meaning most unsatisfied and 1 is the most satisfied
                   if (rdbtnQ1DisStrongly.Checked)
                        Question1Ans = 1;
                   else if (rdbtnQ1Dis.Checked)
                        Question1Ans = 2;
                   else if (rdbtnQ1Neutral.Checked)
                        Question1Ans = 3;
                   else if (rdbtnQ1Agree.Checked)
                        Question1Ans = 4;
                   else if (rdbtnQ1AgreeStrongly.Checked)
                        Question1Ans = 5;
                 int Question2Ans = 0;
                    //1 meaning most unsatisfied and 2 is the most satisfied
                   if (rdbtnQ2DisStrongly.Checked)
                        Question2Ans = 1;
                   else if (rdbtnQ2Dis.Checked)
                        Question2Ans = 2;
                   else if (rdbtnQ2Neutral.Checked)
                        Question2Ans = 3;
                   else if (rdbtnQ2Agree.Checked)
                        Question2Ans = 4;
                   else if (rdbtnQ2AgreeStrongly.Checked)
                        Question2Ans = 5;
                 int Question3Ans = 0;
                    //1 meaning most unsatisfied and 5 is the most satisfied
                   if (rdbtnQ3DisStrongly.Checked)
                        Question3Ans = 1;
                   else if (rdbtnQ3Dis.Checked)
                        Question3Ans = 2;
                   else if (rdbtnQ3Neutral.Checked)
                        Question3Ans = 3;
                   else if (rdbtnQ3Agree.Checked)
                        Question3Ans = 4;
                   else if (rdbtnQ3AgreeStrongly.Checked)
                        Question3Ans = 5;
                 #endregion
                ValidationResult res = RequestLogic.AddSurveyDetails(strReqBy, strReqPhone,strComments,Convert.ToInt32(wrnumber), Question1Ans,Question2Ans,Question3Ans,Question5Ans);
                if (res.Success)
                {
                    Response.Redirect("customersurveydetails.aspx?wonumber=" + lbWRnumber.Text);
                   // ClientScript.RegisterStartupScript(this.GetType(), "onfinish", "ShowPopup('hi');", true);
                }
                else
                { lbMessage.Text = res.Reason; }
            }
            else
            { 
                //show error
                lbMessage.Text = "Missed Required Answer.";
            }

           
        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            clearText();

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "onload", "cancel();", true);

        }
    }
}