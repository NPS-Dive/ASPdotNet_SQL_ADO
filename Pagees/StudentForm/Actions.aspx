<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actions.aspx.cs" Inherits="Session29_SQL01.Pagees.StudentForm.Actions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Contents/CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />
      <title>Actions Page</title>
</head>
<body class="BodyAction">
    <form id="form1" runat="server">
        <div>
            Name:
            <br />
            <input type="text" id="txtName" runat="server" />
            <br />
            Family:
            <br />
            <input type="text" id="txtFamily" runat="server" />
            <br />
            <hr />
            <asp:Button id="btnInsert" runat="server" Text="Add" OnClick="btnInsert_Click"/>
            <asp:Button id="btnUpdate" runat="server" Text="Edit" OnClick="btnUpdate_Click"/>
            <asp:Button id="btnDel" runat="server" Text="Delete" OnClick="btnDel_Click"/>
            <a onclick="CloseWindow()"> Return</a>

        </div>
    </form>
      <script src="../../Contents/js/JavaScript.js" type="text/javascript"></script>
</body>
</html>
