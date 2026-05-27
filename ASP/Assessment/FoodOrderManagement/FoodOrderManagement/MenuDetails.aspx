<%@ Page Title=""
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="MenuDetails.aspx.cs"
Inherits="FoodOrderManagement.MenuDetails" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <style>

        .details-table
        {
            width: 60%;
            margin: auto;
            border-collapse: collapse;
        }

        .details-table td
        {
            padding: 12px;
            border: 1px solid gray;
        }

        .details-table tr:nth-child(odd)
        {
            background-color: #f9f9f9;
        }

        .label-title
        {
            font-weight: bold;
            color: darkred;
            width: 40%;
        }

        h2
        {
            text-align: center;
            color: darkred;
            margin-bottom: 30px;
        }

        .btn
        {
            background-color: darkred;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 15px;
        }

        .btn:hover
        {
            background-color: red;
        }

        .btn-container
        {
            text-align: center;
            margin-top: 20px;
        }

    </style>

    <h2>Food Item Details</h2>

    <table class="details-table">

        <tr>
            <td class="label-title">Menu ID</td>
            <td>
                <asp:Label ID="lblMenuId"
                    runat="server">
                </asp:Label>
            </td>
        </tr>

        <tr>
            <td class="label-title">Item Name</td>
            <td>
                <asp:Label ID="lblItemName"
                    runat="server">
                </asp:Label>
            </td>
        </tr>

        <tr>
            <td class="label-title">Category</td>
            <td>
                <asp:Label ID="lblCategory"
                    runat="server">
                </asp:Label>
            </td>
        </tr>

        <tr>
            <td class="label-title">Food Type</td>
            <td>
                <asp:Label ID="lblFoodType"
                    runat="server">
                </asp:Label>
            </td>
        </tr>

        <tr>
            <td class="label-title">Price</td>
            <td>
                ₹
                <asp:Label ID="lblPrice"
                    runat="server">
                </asp:Label>
            </td>
        </tr>

        <tr>
            <td class="label-title">Available Quantity</td>
            <td>
                <asp:Label ID="lblQuantity"
                    runat="server">
                </asp:Label>
            </td>
        </tr>

        <tr>
            <td class="label-title">Availability</td>
            <td>
                <asp:Label ID="lblAvailable"
                    runat="server">
                </asp:Label>
            </td>
        </tr>

        <tr>
            <td class="label-title">Created Date</td>
            <td>
                <asp:Label ID="lblCreatedDate"
                    runat="server">
                </asp:Label>
            </td>
        </tr>

    </table>

    <div class="btn-container">

        <asp:Button ID="btnBack"
            runat="server"
            Text="Back to Menu"
            CssClass="btn"
            PostBackUrl="~/MenuList.aspx" />

    </div>

</asp:Content>