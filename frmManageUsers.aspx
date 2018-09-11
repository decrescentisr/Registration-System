<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmManageUsers.aspx.cs" Inherits="Annual_Salary_Cost_Calculator.frmManageUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
        <br />
        <br />
        <br />
    
    </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="UserName: "></asp:Label>
            &nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            Password:&nbsp;&nbsp;
            <asp:TextBox ID="txtUserPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Role: "></asp:Label>
            &nbsp;<asp:DropDownList ID="ddlSecurityLevel" runat="server">
                <asp:ListItem Value="A">A</asp:ListItem>
                <asp:ListItem>U</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add User" />
            &nbsp;<br /> &nbsp;<asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PayrollSystem_DBConnectionString %>" DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:PayrollSystem_DBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblUserLogin]" UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                    <asp:Parameter Name="UserID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:GridView ID="grdUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                    <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" SortExpression="SecurityLevel" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
