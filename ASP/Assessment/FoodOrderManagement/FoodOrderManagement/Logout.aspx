<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="Logout.aspx.cs"
    Inherits="FoodOrderManagement.Logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Logout</title>

    <style>

        body
        {
            margin: 0;
            padding: 0;
            font-family: Arial;
            background-color: #f4f4f4;
        }

        .logout-container
        {
            width: 400px;
            margin: 150px auto;
            background-color: white;
            padding: 30px;
            text-align: center;
            border-radius: 10px;
            box-shadow: 0px 0px 10px gray;
        }

        h2
        {
            color: darkred;
        }

        p
        {
            font-size: 18px;
            color: gray;
        }

    </style>

</head>

<body>

    <form id="form1" runat="server">

        <div class="logout-container">

            <h2>You Have Been Logged Out</h2>

            <p>
                Redirecting to Login Page...
            </p>

        </div>

    </form>

</body>

</html>