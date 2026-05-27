<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs"
    Inherits="FoodOrderManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Admin Login</title>

    <style>

        body
        {
            margin: 0;
            padding: 0;
            font-family: Arial;
            background-color: #f4f4f4;
        }

        .login-container
        {
            width: 400px;
            margin: 100px auto;
            background-color: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px gray;
        }

        h2
        {
            text-align: center;
            color: darkred;
            margin-bottom: 30px;
        }

        table
        {
            width: 100%;
        }

        td
        {
            padding: 10px;
        }

        .textbox
        {
            width: 95%;
            padding: 8px;
        }

        .btn
        {
            background-color: darkred;
            color: white;
            border: none;
            padding: 10px 20px;
            cursor: pointer;
            width: 100%;
            font-size: 16px;
        }

        .btn:hover
        {
            background-color: red;
        }

        .message
        {
            color: red;
            font-weight: bold;
        }

        .auto-style1 {
            width: 155px;
        }

    </style>

</head>

<body>

    <form id="form1" runat="server">

        <div class="login-container">

            <h2>Admin Login</h2>

            <table>

                <tr>
                    <td class="auto-style1">Username</td>
                    <td>
                        <asp:TextBox ID="txtUsername"
                            runat="server"
                            CssClass="textbox">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style1">Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword"
                            runat="server"
                            TextMode="Password"
                            CssClass="textbox">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">

                        <asp:Button ID="btnLogin"
                            runat="server"
                            Text="Login"
                            CssClass="btn"
                            OnClick="btnLogin_Click" />

                    </td>
                </tr>

                <tr>
                    <td colspan="2" align="center">

                        <asp:Label ID="lblMessage"
                            runat="server"
                            CssClass="message">
                        </asp:Label>

                    </td>
                </tr>

            </table>

        </div>

    </form>

</body>
</html>