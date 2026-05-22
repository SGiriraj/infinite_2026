<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Validation.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Form</title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="text-align:left; height:541px">

            <asp:Label ID="lblInsert" runat="server"
                Text="Insert Your Details:"
                Font-Bold="true">
            </asp:Label>

            <br /><br />

            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator
                ID="rfvName"
                runat="server"
                ControlToValidate="TextBox1"
                ErrorMessage="Enter Name"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="FamilyName"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp; :

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator
                ID="rfvFamily"
                runat="server"
                ControlToValidate="TextBox2"
                ErrorMessage="Enter Family Name"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br /><br />

            <asp:CompareValidator
                ID="cvName"
                runat="server"
                ControlToValidate="TextBox1"
                ControlToCompare="TextBox2"
                Operator="NotEqual"
                Type="String"
                ErrorMessage="Name and Family Name should be different"
                ForeColor="Red">
            </asp:CompareValidator>

            <br /><br />

            <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :

            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            <asp:RegularExpressionValidator
                ID="revAddress"
                runat="server"
                ControlToValidate="TextBox3"
                ValidationExpression="^.{2,}$"
                ErrorMessage="Minimum 2 letters"
                ForeColor="Red">
            </asp:RegularExpressionValidator>

            <br /><br />

            <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :

            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

            <asp:RegularExpressionValidator
                ID="revCity"
                runat="server"
                ControlToValidate="TextBox4"
                ValidationExpression="^.{2,}$"
                ErrorMessage="Minimum 2 letters"
                ForeColor="Red">
            </asp:RegularExpressionValidator>

            <br /><br />

            <asp:Label ID="Label5" runat="server" Text="ZipCode"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :

            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            <asp:RegularExpressionValidator
                ID="revZip"
                runat="server"
                ControlToValidate="TextBox5"
                ValidationExpression="^\d{5}$"
                ErrorMessage="Zip Code must be 5 digits"
                ForeColor="Red">
            </asp:RegularExpressionValidator>

            <br /><br />

            <asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :

            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>

            <asp:RegularExpressionValidator
                ID="revPhone"
                runat="server"
                ControlToValidate="TextBox6"
                ValidationExpression="^\d{2,3}-\d{7}$"
                ErrorMessage="Format XX-XXXXXXX or XXX-XXXXXXX"
                ForeColor="Red">
            </asp:RegularExpressionValidator>

            <br /><br />

            <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :

            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>

            <asp:RegularExpressionValidator
                ID="revEmail"
                runat="server"
                ControlToValidate="TextBox7"
                ValidationExpression="\w+([.-]?\w+)*@\w+([.-]?\w+)*\.\w{2,3}"
                ErrorMessage="Invalid Email"
                ForeColor="Red">
            </asp:RegularExpressionValidator>

            <br /><br />

            <asp:Button ID="Button1"
                runat="server"
                Text="Check" />

            <br /><br />

            <asp:ValidationSummary
                ID="ValidationSummary1"
                runat="server"
                ForeColor="Blue" />

        </div>

    </form>
</body>
</html>