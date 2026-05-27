<%@ Page Title=""
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="AddEditMenu.aspx.cs"
Inherits="FoodOrderManagement.AddEditMenu" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <style>

        .form-table
        {
            margin: auto;
            width: 60%;
        }

        .form-table td
        {
            padding: 12px;
        }

        .textbox
        {
            width: 250px;
            padding: 8px;
        }

        .dropdown
        {
            width: 270px;
            padding: 8px;
        }

        .btn
        {
            background-color: darkred;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
        }

        .btn:hover
        {
            background-color: red;
        }

        h2
        {
            text-align: center;
            color: darkred;
            margin-bottom: 30px;
        }

        .validator
        {
            color: red;
            font-size: 14px;
        }

    </style>

    <h2>Add / Edit Food Item</h2>

    <asp:ValidationSummary
        ID="vs1"
        runat="server"
        ForeColor="Red" />

    <table class="form-table">

        <tr>
            <td>Item Name</td>

            <td>

                <asp:TextBox ID="txtItemName"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>

                <br />

                <asp:RequiredFieldValidator
                    ID="rfvItemName"
                    runat="server"
                    ControlToValidate="txtItemName"
                    ErrorMessage="Item Name Required"
                    CssClass="validator">
                </asp:RequiredFieldValidator>

            </td>
        </tr>

        <tr>
            <td>Category</td>

            <td>

                <asp:DropDownList ID="ddlCategory"
                    runat="server"
                    CssClass="dropdown">

                    <asp:ListItem>Breakfast</asp:ListItem>
                    <asp:ListItem>Lunch</asp:ListItem>
                    <asp:ListItem>Dinner</asp:ListItem>
                    <asp:ListItem>Snacks</asp:ListItem>
                    <asp:ListItem>Beverages</asp:ListItem>

                </asp:DropDownList>

            </td>
        </tr>

        <tr>
            <td>Food Type</td>

            <td>

                <asp:RadioButtonList ID="rblFoodType"
                    runat="server">

                    <asp:ListItem>Veg</asp:ListItem>
                    <asp:ListItem>Non-Veg</asp:ListItem>

                </asp:RadioButtonList>

            </td>
        </tr>

        <tr>
            <td>Price</td>

            <td>

                <asp:TextBox ID="txtPrice"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>

                <br />

                <asp:RequiredFieldValidator
                    ID="rfvPrice"
                    runat="server"
                    ControlToValidate="txtPrice"
                    ErrorMessage="Price Required"
                    CssClass="validator">
                </asp:RequiredFieldValidator>

            </td>
        </tr>

        <tr>
            <td>Quantity</td>

            <td>

                <asp:TextBox ID="txtQuantity"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>

            </td>
        </tr>

        <tr>
            <td>Available</td>

            <td>

                <asp:CheckBox ID="chkAvailable"
                    runat="server" />

            </td>
        </tr>

        <tr>
            <td></td>

            <td>

                <asp:Button ID="btnSave"
                    runat="server"
                    Text="Save"
                    CssClass="btn"
                    OnClick="btnSave_Click" />

            </td>
        </tr>

    </table>

</asp:Content>