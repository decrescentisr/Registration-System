<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSalaryCostCalculator.aspx.cs" Inherits="Annual_Salary_Cost_Calculator.frmSalaryCostCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span style="color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" NavigateUrl="~/frmMain.aspx">HyperLink</asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Annual Hours"></asp:Label>
        :&nbsp;
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Pay Rate"></asp:Label>
        :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCalculateSalary" runat="server" OnClick="btnCalculate_Click" Text="Calculate Salary" />
        <br />
        <br />
        <asp:Label ID="lblAnnualSalary" runat="server"></asp:Label>
        </span>
    
    </div>
    </form>
</body>
</html>
