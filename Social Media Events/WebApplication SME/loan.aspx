﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loan.aspx.cs" Inherits="WebApplication_SME.Loan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link rel="shortcut icon" href="../../assets/ico/favicon.ico" />

    <title>Social Media Event</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <!-- Bootstrap theme -->
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
    <!-- Custom styles for this page -->
    <link href="loan.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="index.aspx">Social Media Event</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a href="reservation.aspx">Reservation</a></li>
                        <li class="active"><a href="loan.aspx">Loan Items</a></li>
                        <li><a href="entry.aspx">Entry Control</a></li>
                        <li>
                            <asp:HyperLink href="login.aspx" ID="btn_login" runat="server">Login</asp:HyperLink></li>
                    </ul>
                </div>
            </div>
        </div>
        <div id="label" class="container ">
            <asp:Label ID="label1" runat="server" />
        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
