<%@ Page Title=""
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="MenuList.aspx.cs"
Inherits="FoodOrderManagement.MenuList" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <style>

        .grid
        {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        .grid th
        {
            background-color: darkred;
            color: white;
            padding: 10px;
            text-align: center;
        }

        .grid td
        {
            padding: 10px;
            text-align: center;
            background-color: #f9f9f9;
        }

        .btn
        {
            background-color: darkred;
            color: white;
            padding: 10px 15px;
            border: none;
            font-size: 15px;
            cursor: pointer;
            border-radius: 5px;
        }

        .btn:hover
        {
            background-color: red;
        }

        h2
        {
            text-align: center;
            color: darkred;
        }

        .action-link
        {
            color: blue;
            text-decoration: none;
            font-weight: bold;
        }

    </style>

    <h2>Food Menu List</h2>

    <div style="text-align:center; margin-bottom:20px;">

        <asp:Button ID="btnAddMenu"
            runat="server"
            Text="Add New Food Item"
            CssClass="btn"
            PostBackUrl="~/AddEditMenu.aspx" />

    </div>

    <asp:GridView ID="gvMenu"
        runat="server"
        AutoGenerateColumns="False"
        CssClass="grid"
        GridLines="None">

        <Columns>

            <asp:BoundField DataField="MenuId"
                HeaderText="Menu ID" />

            <asp:BoundField DataField="ItemName"
                HeaderText="Item Name" />

            <asp:BoundField DataField="Category"
                HeaderText="Category" />

            <asp:BoundField DataField="FoodType"
                HeaderText="Food Type" />

            <asp:BoundField DataField="Price"
                HeaderText="Price" />

            <asp:BoundField DataField="AvailableQuantity"
                HeaderText="Quantity" />

            <asp:BoundField DataField="CreatedDate"
                HeaderText="Created Date" />

            <asp:HyperLinkField
                HeaderText="View"
                Text="View"
                DataNavigateUrlFields="MenuId"
                DataNavigateUrlFormatString="MenuDetails.aspx?MenuId={0}" />

            <asp:HyperLinkField
                HeaderText="Edit"
                Text="Edit"
                DataNavigateUrlFields="MenuId"
                DataNavigateUrlFormatString="AddEditMenu.aspx?MenuId={0}" />

            <asp:TemplateField HeaderText="Delete">

                <ItemTemplate>

                    <asp:LinkButton ID="lnkDelete"
                        runat="server"
                        Text="Delete"
                        CssClass="action-link"
                        CommandArgument='<%# Eval("MenuId") %>'
                        OnClick="lnkDelete_Click"
                        OnClientClick="return confirm('Are you sure to delete?');">
                    </asp:LinkButton>

                </ItemTemplate>

            </asp:TemplateField>

        </Columns>

    </asp:GridView>

</asp:Content>