<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Session29_SQL01.Pagees.StudentForm.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Contents/CSS/StyleSheet1.css" rel="stylesheet" type="text/css"/>
    <title>Index Page</title>
  
  
</head>
<body>
    <form id="form1" runat="server">
        <div class="mainDiv">
            <a onclick="OpenPage(-1)" class="aNew">New</a>
            <br />
            <asp:GridView ID="GridViewStudent" AllowPaging="true" HeaderStyle-CssClass="gridHeader" runat="server" AutoGenerateColumns="false" GridLines="None" CellPadding="4" OnRowDataBound="GridViewStudent_RowDataBound" OnPageIndexChanging="GridViewStudent_PageIndexChanging">
               <Columns>
                   <asp:BoundField DataField="RowNumber" HeaderText="#"/>
                   <asp:BoundField DataField="Name" HeaderText="Student name"/>
                   <asp:BoundField DataField="LastName" HeaderText="Student Family"/>
                   <asp:TemplateField>
                       <ItemTemplate>
                           <a onclick='<%# Eval("ID","OpenPage({0})") %>'>
                               <img src="../../Contents/img/edit-48.png" />

                           </a>
                           
                       </ItemTemplate>
                   </asp:TemplateField>
               </Columns>
            </asp:GridView>
        </div>
    </form>
      <script src="../../Contents/js/JavaScript.js" type="text/javascript"></script>
</body>
</html>
