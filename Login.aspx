﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PostGradOffice.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Login</div>
        <p>
            UserName</p>
        <p>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
        </p>
        <p>
            Password</p>
        <p>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="signIn" runat="server" OnClick="sign" Text="signIn" />
        </p>
    </form>
</body>
</html>
