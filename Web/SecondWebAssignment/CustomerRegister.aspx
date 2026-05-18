<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="CustomerRegister.aspx.cs"
    Inherits="WebApplication3.CustomerRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>ABC Bank Registration</title>

    <style>

        body {

            font-family: Arial;

            background-color: #f0f4f7;
        }

        .container {

            width: 900px;

            margin: 20px auto;

            background: white;

            padding: 25px;

            border-radius: 10px;

            box-shadow: 0px 0px 10px gray;
        }

        h1 {

            text-align: center;

            color: darkblue;
        }

        table {

            width: 100%;
        }

        td {

            padding: 10px;
        }

        .btn {

            background-color: darkblue;

            color: white;

            padding: 10px 20px;

            border: none;

            border-radius: 5px;

            font-size: 16px;
        }

        .grid {

            margin-top: 20px;
        }

        .error {

            color: red;
        }

    </style>

</head>

<body>

    <form id="form1" runat="server">

        <div class="container">

            <h1>ABC Bank Customer Registration</h1>

            <table>

                <tr>

                    <td>Full Name</td>

                    <td>

                        <asp:TextBox ID="txtName"
                            runat="server">
                        </asp:TextBox>

                        <asp:RequiredFieldValidator
                            ID="reqName"
                            runat="server"
                            ControlToValidate="txtName"
                            ErrorMessage="Name Required"
                            CssClass="error">
                        </asp:RequiredFieldValidator>

                    </td>

                </tr>

                <tr>

                    <td>Email</td>

                    <td>

                        <asp:TextBox ID="txtEmail"
                            runat="server">
                        </asp:TextBox>

                    </td>

                </tr>

                <tr>

                    <td>Mobile</td>

                    <td>

                        <asp:TextBox ID="txtMobile"
                            runat="server">
                        </asp:TextBox>

                    </td>

                </tr>

                <tr>

                    <td>Gender</td>

                    <td>

                        <asp:RadioButtonList ID="rblGender"
                            runat="server"
                            RepeatDirection="Horizontal">

                            <asp:ListItem>Male</asp:ListItem>

                            <asp:ListItem>Female</asp:ListItem>

                        </asp:RadioButtonList>

                    </td>

                </tr>

                <tr>

                    <td>Address</td>

                    <td>

                        <asp:TextBox ID="txtAddress"
                            runat="server"
                            TextMode="MultiLine">
                        </asp:TextBox>

                    </td>

                </tr>

                <tr>

                    <td>City</td>

                    <td>

                        <asp:DropDownList ID="ddlCity"
                            runat="server">

                            <asp:ListItem>Chennai</asp:ListItem>

                            <asp:ListItem>Bangalore</asp:ListItem>

                            <asp:ListItem>Hyderabad</asp:ListItem>

                            <asp:ListItem>Mumbai</asp:ListItem>

                        </asp:DropDownList>

                    </td>

                </tr>

                <tr>

                    <td>Account Type</td>

                    <td>

                        <asp:DropDownList ID="ddlAccountType"
                            runat="server">

                            <asp:ListItem>Savings</asp:ListItem>

                            <asp:ListItem>Current</asp:ListItem>

                            <asp:ListItem>Fixed Deposit</asp:ListItem>

                        </asp:DropDownList>

                    </td>

                </tr>

                <tr>

                    <td>Opening Balance</td>

                    <td>

                        <asp:TextBox ID="txtBalance"
                            runat="server">
                        </asp:TextBox>

                    </td>

                </tr>

                <tr>

                    <td>ID Proof Upload</td>

                    <td>

                        <asp:FileUpload ID="fuIDProof"
                            runat="server" />

                    </td>

                </tr>

                <tr>

                    <td colspan="2"
                        style="text-align:center">

                        <asp:Button ID="btnRegister"
                            runat="server"
                            Text="Register Customer"
                            CssClass="btn"
                            OnClick="btnRegister_Click" />

                    </td>

                </tr>

            </table>

            <br />

            <asp:Label ID="lblMessage"
                runat="server">
            </asp:Label>

            <br />
            <br />

            <asp:GridView ID="gvCustomers"
                runat="server"
                AutoGenerateColumns="False"
                CssClass="grid"
                BorderWidth="2"
                CellPadding="10"
                GridLines="Both">

                <Columns>

                    <asp:BoundField
                        DataField="CustomerID"
                        HeaderText="Customer ID" />

                    <asp:BoundField
                        DataField="AccountNumber"
                        HeaderText="Account Number" />

                    <asp:BoundField
                        DataField="FullName"
                        HeaderText="Name" />

                    <asp:BoundField
                        DataField="Email"
                        HeaderText="Email" />

                    <asp:BoundField
                        DataField="Mobile"
                        HeaderText="Mobile" />

                    <asp:BoundField
                        DataField="Gender"
                        HeaderText="Gender" />

                    <asp:BoundField
                        DataField="City"
                        HeaderText="City" />

                    <asp:BoundField
                        DataField="AccountType"
                        HeaderText="Account Type" />

                    <asp:BoundField
                        DataField="Balance"
                        HeaderText="Balance" />

                </Columns>

            </asp:GridView>

        </div>

    </form>

</body>

</html>