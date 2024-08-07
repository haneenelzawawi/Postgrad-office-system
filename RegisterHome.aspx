<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterHome.aspx.cs" Inherits="PostGradOffice.RegisterHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Please choose your type</p>
        <p>
            Student</p>
        <p>
            <asp:Button ID="Student" runat="server" Text="Ok" OnClick="Student_Click" />
        </p>
        <p>
            Supervisor</p>
        <p>
            <asp:Button ID="Supervisor" runat="server" Text="Ok" OnClick="Supervisor_Click" />
        </p>
        <p>
            Examiner</p>
        <p>
            <asp:Button ID="Examiner" runat="server" Text="Ok" OnClick="Examiner_Click" />
        </p>
    </form>
</body>
</html>
