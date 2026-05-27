<%@ Page Title=""
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="OrderStats.aspx.cs"
Inherits="FoodOrderManagement.OrderStats" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <style>

        .stats-box
        {
            width: 60%;
            margin: auto;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px gray;
            background-color: white;
        }

        h2
        {
            text-align: center;
            color: darkred;
        }

        .label
        {
            font-weight: bold;
            color: darkred;
        }

        .grid
        {
            width: 100%;
            margin-top: 20px;
            border-collapse: collapse;
        }

        .grid th
        {
            background-color: darkred;
            color: white;
            padding: 10px;
        }

        .grid td
        {
            padding: 10px;
            text-align: center;
            border: 1px solid gray;
        }

    </style>

    <div class="stats-box">

        <h2>Order Statistics</h2>

        <p>
            <span class="label">Total Visitors :</span>

            <asp:Label ID="lblTotalUsers"
                runat="server">
            </asp:Label>
        </p>

        <p>
            <span class="label">Current Active Users :</span>

            <asp:Label ID="lblActiveUsers"
                runat="server">
            </asp:Label>
        </p>

        <h3 style="color:darkred;">
            Food Category Statistics (Cached)
        </h3>

        <asp:GridView ID="gvStats"
            runat="server"
            AutoGenerateColumns="true"
            CssClass="grid">
        </asp:GridView>

    </div>

</asp:Content>