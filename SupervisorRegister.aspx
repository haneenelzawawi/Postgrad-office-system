<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupervisorRegister.aspx.cs" Inherits="PostGradOffice.SupervisorRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Please Enter Your Information</p>
        <p>
            First Name</p>
        <p>
            <asp:TextBox ID="First" runat="server" ></asp:TextBox>
        </p>
        <p>
            Last Name</p>
        <p>
            <asp:TextBox ID="Last" runat="server" ></asp:TextBox>
        </p>
        <p>
            Faculty</p>
        <p>
            <asp:TextBox ID="Faculty" runat="server" ></asp:TextBox>
        </p>
        <p>
            Email</p>
        <p>
            <asp:TextBox ID="Email" runat="server" ></asp:TextBox>
        </p>
        <p>
            Password</p>
        <p>
            <asp:TextBox ID="Password" runat="server" ></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="RegisterS" runat="server" Text="Register" OnClick="RegisterS_Click" />
        </p>
    </form>
</body>
</html>
