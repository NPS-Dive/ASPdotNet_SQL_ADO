<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllStudents.aspx.cs" Inherits="Session29_SQL01.Pagees.StudentForm.ShowAllStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <link href="../../Contents/CSS/StyleSheet1.css" rel="stylesheet" />
    <title>Show All Students</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="mainDiv">
            <asp:GridView CssClass="gridNews" ID="myGrid" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div class="MainNewsDiv">
                                <div class="Newsheader">
                                    <%# Eval("ID") %>
                                    <br />
                                </div><!--Head of News-->
                                
                                <hr />
                                <div>
                                    <%# Eval("Name") %>
                                    <br />
                                    <%# Eval("Name") %>
                                    <br />
                                    <%# Eval("Name") %>
                                    <br />
                                    <%# Eval("Name") %>
                                    <br />
                                    <%# Eval("Name") %>
                                    <br />
                                </div> <!-- Body of news-->
                               
                                <div class="MoreNews">
                                    <a href='<%#Eval("ID","Actions.aspx?ID={0}") %>'>More ...</a>

                                </div><!--More-->
                                
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <script src="../../Contents/js/JavaScript.js" type="text/javascript"></script>
</body>
</html>
