<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Product_Dropdown.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Dropdown</title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="text-align:left">

            <h2>Product Details</h2>

            <asp:Label ID="Label2"
                runat="server"
                Text="Select Product">
            </asp:Label>

            &nbsp;&nbsp;&nbsp; :

            <asp:DropDownList ID="DropDownList1"
                runat="server"
                AutoPostBack="True"
                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">

                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Mobile</asp:ListItem>
                <asp:ListItem>Laptop</asp:ListItem>
                <asp:ListItem>Headphone</asp:ListItem>

            </asp:DropDownList>

            <br /><br />

            <asp:Image ID="Image1"
                runat="server"
                Height="200px"
                Width="200px"
                BorderWidth="2">
            </asp:Image>

            <br /><br />

            <asp:Button ID="Button1"
                runat="server"
                Text="Get Price"
                OnClick="Button1_Click" />

            <br /><br />

            <asp:Label ID="Label1"
                runat="server"
                Font-Bold="True"
                ForeColor="Blue">
            </asp:Label>

        </div>

    </form>
</body>
</html>