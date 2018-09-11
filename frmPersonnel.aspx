<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersonnel.aspx.cs" Inherits="Annual_Salary_Cost_Calculator.frmPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" NavigateUrl="~/frmMain.aspx">HyperLink</asp:HyperLink>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Information to Submit:"></asp:Label>
&nbsp;
        <asp:Panel ID="txtVerifiedInfo" runat="server" Height="300px" HorizontalAlign="Left" ScrollBars="Both" Width="390px">
            <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Pay Rate:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPayRate" ErrorMessage="Pay Rate is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Start Date:"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate" ErrorMessage="Date must be in this format: mm/dd/yyy" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label6" runat="server" Text="End Date:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate" ErrorMessage="Date must be in this format: mm/dd/yyy" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            &nbsp;&nbsp; &nbsp;&nbsp;
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
