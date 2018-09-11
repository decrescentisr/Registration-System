<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="Annual_Salary_Cost_Calculator.frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="350px" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" Width="500px" />
        <br />
        <br />
        <asp:ImageButton ID="imgbtnCalculator" runat="server" Height="80px" ImageUrl="~/Images/calculator.jpg" Width="106px" Visible="False" />
&nbsp;<asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/frmSalaryCostCalculator.aspx" Visible="False">Annual Salary Calculator</asp:LinkButton>
        <br />
        <br />
        <asp:ImageButton ID="imgbtnNewEmployee" runat="server" Height="78px" ImageUrl="~/Images/image554511.jpg" Width="125px" Visible="False" />
&nbsp;<asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx" Visible="False">Add New Employee</asp:LinkButton>
    
        <br />
        <br />
        <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" ImageUrl="~/Images/Database_iStock_Thumbnail.jpg" Visible="False" />
&nbsp;<asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx" Visible="False">User Activity Form</asp:LinkButton>
    
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="imgbtnViewPersonnel" runat="server" ImageUrl="~/Images/image557418.jpg" Visible="False" />
&nbsp;&nbsp;
        <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" Visible="False">View Personnel</asp:LinkButton>
        <br />
        <br />
        <asp:Image ID="imgbtnSearch" runat="server" ImageUrl="~/Images/image557415.jpg" Visible="False" />
&nbsp;<asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/frmSearchPersonnel.aspx" Visible="False">Search Personnel</asp:LinkButton>
    
        <br />
        <br />
        <br />
        <asp:Image ID="imgbtnEditEmployees" runat="server" ImageUrl="~/Images/editthumbnail.png" Visible="False" />
&nbsp;
        <asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/frmEditPersonnel.aspx" Visible="False">Edit Personnel</asp:LinkButton>
    
        <br />
        <br />
        <asp:Image ID="imgbtnEditUsers" runat="server" ImageUrl="~/Images/manageusers.jpg" Visible="False" />
&nbsp;<asp:LinkButton ID="linkbtnEditUsers" runat="server" PostBackUrl="~/frmManageUsers.aspx" Visible="False">Edit Users</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
