<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="customersurveydetails.aspx.cs" Inherits="CMMS2015.Survey.SurveyDetail" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
          <div class="content-wrapper">
           <b> &nbsp;&nbsp;&nbsp;Customer Survey Details</b>
        </div>

    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">   
    <table width="100%">
        <tr>
             <td colspan="2" align="right">
                  <asp:Button ID="Button1" Text="Close Window" runat="server" CssClass="submitRed" OnClientClick="javascript:window.close();" />
                   
             </td>
         </tr>
         <tr><td colspan="2"><font color="red"><asp:label id="lbNoRequestMessage" runat="Server"></asp:label></font></td></tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Maintenance Request#: </b></td>
            <td class="surveyTableRightCell">M<asp:Label id="lbWRNumber" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Description:</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbDescription" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Work Location Building:</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbBuilding" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Work Location Room:</b></td>
           <td class="surveyTableRightCell"><asp:Label id="lbRoom" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Requested on:</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbRequestedOn" runat="server"></asp:Label></td>
        </tr>
          <tr>
            <td class="surveyTableLeftCell"><b>Requested by:</b></td>
           <td class="surveyTableRightCell"><asp:Label id="lbRequestedBy" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td class="surveyTableLeftCell"><b>Work Order Number:</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbWONumber" runat="server"></asp:Label></td>
        </tr>
           <tr>
            <td class="surveyTableLeftCell"><b>Shop/Group:</b></td>
           <td class="surveyTableRightCell"><asp:Label id="lbShop" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td class="surveyTableLeftCell"><b>Status:</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbStatus" runat="server"></asp:Label></td>
        </tr>
         
         <tr>
            <td class="surveyTableLeftCell"><b>Comments:</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbReqComments" runat="server"></asp:Label></td>
        </tr>
    </table>
    <div align="center">
        <p style="background-color:#f8b149; color: #000; font-weight: bold;line-height: 35px;">1 = Disagree Strongly | 2 = Disagree | 3 = Neutral | 4 = Agree | 5 = Agree Strongly</p>
    </div>
    <table width="100%">
         <tr><td colspan="2"><font color="red"><asp:label id="lbNoSurveyMessage" runat="Server"></asp:label></font></td></tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Date/Time</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbCreatedOn" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Customer Name:</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbCustomerName" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Customer Phone:</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbCustomerPhone" runat="server"></asp:Label></td>
        </tr>
         <tr>
            <td class="surveyTableLeftCell"><b>(Required) Overall, the service was done to your satisfaction</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbQuestion5Ans" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>(Optional) The Service Request was taken in a professional manner</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbQuestion1Ans" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>(Optional) The Service Request was completed in a timely manner</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbQuestion2Ans" runat="server"></asp:Label></td>
        </tr>
          <tr>
            <td class="surveyTableLeftCell"><b>(Optional) The Technician was courteous and professional</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbQuestion3Ans" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="surveyTableLeftCell"><b>Comments</b></td>
            <td class="surveyTableRightCell"><asp:Label id="lbComments" runat="server"></asp:Label></td>
        </tr>
         <tr>
             <td colspan="2" align="right"><br /><br />
                  <asp:Button ID="btnCancel" Text="Close Window" runat="server" CssClass="submitRed" OnClientClick="javascript:window.close();" />
                   
             </td>
         </tr>
    </table>

             
</asp:Content>
