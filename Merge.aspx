<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Merge.aspx.cs" Inherits="CarDealership.Merge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/Content/bootstrap.min.css">
    <link rel="stylesheet" href="/Content/GridStyles.css">
</head>
<body>
    <form id="form1" runat="server">
          <div class="jumbotron bg2 text-center">
            <h1>Merge</h1>
        </div>
        
            <asp:GridView ID="GridViewMerged" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                 <Columns>
                     <asp:BoundField DataField="UserID" HeaderText="UserId" SortExpression="UserID" />
                     <asp:BoundField DataField="UserName" HeaderText="Name" SortExpression="UserName" />
                     <asp:BoundField DataField="Mf_Name" HeaderText="Manufacturer" SortExpression="Mf_Name" />
                     <asp:BoundField DataField="Mf_Location" HeaderText="Location" SortExpression="Mf_Location" />
                 </Columns>

             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CarFactoryConnectionString %>" SelectCommand="SELECT u.UserId,u.UserName,Mf_Name, Mf_Location FROM Manufacturers m,Users u where u.userid=m.userid"></asp:SqlDataSource>
            
            <div class="row">
            <div class="col-md-2">
                <asp:Label ID="Label1" runat="server" Text="UserID"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br/>
                <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                   <br/>
                <asp:Label ID="Label3" runat="server" Text="Manufacturer"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                   <br/>
                <asp:Label ID="Label4" runat="server" Text="Location"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                   <br/>
                <asp:Button ID="ButtonAdd" runat="server" Text="Merge" CssClass="btn btn-default" OnClick="ButtonAdd_Click" />
            </div>
                </div>
      
    </form>
</body>
</html>
