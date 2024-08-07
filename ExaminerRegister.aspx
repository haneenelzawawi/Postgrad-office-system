<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExaminerRegister.aspx.cs" Inherits="PostGradOffice.ExaminerRegister" %>

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
            <asp:TextBox ID="First" runat="server" ></asp:TextBox>
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
            Field Of Work</p>
            <asp:TextBox ID="Field" runat="server"></asp:TextBox>
        <p>
            Enter 1 If You Are Egyptian Or 0 Otherwise
        </p>
        <p>
            <asp:TextBox ID="Nationality" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="RegisterE" runat="server" Text="Register" OnClick="RegisterE_Click" />
        </p>
    </form>
</body>
</html>
