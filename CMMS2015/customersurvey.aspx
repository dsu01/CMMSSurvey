<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="customersurvey.aspx.cs" Inherits="CMMS2015.Survey.SurveyEntryForm" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
   
       <section class="featured">
        <div class="content-wrapper">
           <b> &nbsp;&nbsp;&nbsp;Customer Survey Entry Form</b>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
 <%--  <script type="text/javascript">
       function ShowPopup(message) {
           $(function () {
               $("#dialog").html(message);
               $("#dialog").dialog({
                   title: "jQuery Dialog Popup",
                   buttons: {
                       Close: function () {
                           $(this).dialog('close');
                       }
                   },
                   modal: true
               });
           });
       };
</script>
    <div id="dialog" style="display: none" />--%>
    <h3>Customer Survey on Maintenance Request#: M<asp:Label id="lbWRnumber" runat="server"></asp:Label></h3>
    <table style="width:100%; ">
        <tr style="border-bottom:solid #999 1px;">
            <td style="width:130px;"><b>Requested On:</b></td>
            <td><asp:Label id="lbRequestedOn" runat="server"></asp:Label></td>
        </tr>
        <tr style="border-bottom:solid #999 1px;">
            <td><b>Description:</b></td>
            <td><asp:Label id="lbDescription" runat="server"></asp:Label></td>
        </tr>
        <tr style="border-bottom:solid #999 1px;">
            <td><b>Building:</b></td>
            <td><asp:Label id="lbBuilding" runat="server"></asp:Label></td>
        </tr>
        <tr style="border-bottom:solid #999 1px;">
            <td><b>Room:</b></td>
           <td><asp:Label id="lbRoom" runat="server"></asp:Label></td>
        </tr>
        <tr style="border-bottom:solid #999 1px;">
            <td><b>Name:</b></td>
            <td><asp:Label id="lbName" runat="server"></asp:Label></td>
        </tr>
          <tr style="border-bottom:solid #999 1px;">
            <td><b>Phone:</b></td>
           <td><asp:Label id="lbPhone" runat="server"></asp:Label></td>
        </tr>
        <tr style="border-bottom:solid #999 1px;">
            <td><b>Comments:</b></td>
            <td><asp:Label id="lbComments" runat="server"></asp:Label></td>
        </tr>
    </table>
    <br />
 
    <table style="width:100%; border:solid #f8b149 2px; text-align:center; margin-bottom: 20px;">
            <tr>
                <td style="width:300px; padding: 3px;" align="left"><b>Question (required):</b></td>
                 <td style="width:20px; padding: 5px;"><b>Disagree Strongly</b></td>
                 <td style="width:20px;"><b>Disagree</b></td>
                 <td><b>Neutral</b></td>
                 <td><b>Agree</b></td>
                 <td><b>Agree Strongly</b></td>
            </tr>
             <tr>
                <td style="padding: 3px;" align="left"><b>Overall, the service was done to your satisfaction:</b></td>
                 <td><asp:RadioButton ID="rdbtnQ5DisStrongly" GroupName="rdbtnQ5" runat="server" Width="120px" Height="30px" /></td>
                 <td><asp:RadioButton ID="rdbtnQ5Dis" GroupName="rdbtnQ5" runat="server" /></td>
                 <td><asp:Radiobutton id="rdbtnQ5Neutral" GroupName="rdbtnQ5" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ5Agree" GroupName="rdbtnQ5" runat="server"/></td>
                <td><asp:Radiobutton id="rdbtnQ5AgreeStrongly" GroupName="rdbtnQ5" runat="server"/></td>
            </tr>
         <tr>
                <td colspan="6"  style="padding: 3px;" align="left">Optional:</td>
             </tr>
          <tr>
                <td style="padding: 3px;" align="left">The Service Request was taken in a professional manner:</td>
                 <td><asp:Radiobutton id="rdbtnQ1DisStrongly" GroupName="rdbtnQ1" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ1Dis" GroupName="rdbtnQ1" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ1Neutral" GroupName="rdbtnQ1" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ1Agree" GroupName="rdbtnQ1" runat="server"/></td>
                <td><asp:Radiobutton id="rdbtnQ1AgreeStrongly" GroupName="rdbtnQ1" runat="server"/></td>
            </tr>
       
             <tr>
                <td style="padding: 3px;" align="left">The Service was completed in a timely manner:</td>
                <td><asp:Radiobutton id="rdbtnQ2DisStrongly" GroupName="rdbtnQ2" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ2Dis" GroupName="rdbtnQ2" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ2Neutral" GroupName="rdbtnQ2" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ2Agree" GroupName="rdbtnQ2" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ2AgreeStrongly" GroupName="rdbtnQ2" runat="server"/></td>
            </tr>
              <tr>
                <td style="padding: 3px;" align="left">The Technician was courteous and professional:</td>
                 <td><asp:Radiobutton id="rdbtnQ3DisStrongly" GroupName="rdbtnQ3" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ3Dis" GroupName="rdbtnQ3" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ3Neutral" GroupName="rdbtnQ3" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ3Agree" GroupName="rdbtnQ3" runat="server"/></td>
                 <td><asp:Radiobutton id="rdbtnQ3AgreeStrongly" GroupName="rdbtnQ3" runat="server"/></td>
            </tr>
              <tr>
                <td style="padding: 3px;" align="left"">Additional Comments:</td>
                 <td colspan="5" align="left"><asp:TextBox id="txtComments" rows="5" style="width:100%;" TextMode="MultiLine" runat="Server"></asp:TextBox>

                 </td>
            </tr>
            <tr>
                <td colspan="6" ><div class="popup_Buttons">
                    <asp:label id="lbMessage" runat="server" CssClass="errortext"></asp:label> <br />
                     <asp:Button ID="btnSubmit" Text="Submit" runat="server" CssClass="submitGreen" OnClick="btnSubmit_Click" OnClientClick="javascript:return confirm('Would you like to submit now?');" />
                     &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnReset" Text="Reset" runat="server" CssClass="submitYellow" OnClick="btnReset_Click" />  &nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="btnCancel" Text="Cancel" runat="server" CssClass="submitRed" OnClientClick="javascript:window.close();" />
                   
                    
                     </div>

                </td>
            </tr>
             
    </table>
   
</asp:Content>

