<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegister.aspx.cs" Inherits="PostGradOffice.StudentRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter Your Information</div>
        <p>
            First Name</p>
        <p>
            <asp:TextBox ID="First" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name</p>
        <p>
            <asp:TextBox ID="Last" runat="server"></asp:TextBox>
        </p>
        <p>
            Email</p>
        <p>
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </p>
        <p>
            Password</p>
        <p>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        </p>
        <p>
            Faculty</p>
        <p>
            <asp:TextBox ID="Faculty" runat="server"></asp:TextBox>
        </p>
        <p>
            Address</p>
        <p>
            <asp:TextBox ID="Address" runat="server"></asp:TextBox>
        </p>
        <p>
            Please Enter 1 If You Are A Gucian Else Enter 0
        </p>
        <p>
            <asp:TextBox ID="Gucian" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="RegisterG" runat="server" Text="Register" OnClick="RegisterG_Click" />
        </p>
    </form>
</body>
</html>
