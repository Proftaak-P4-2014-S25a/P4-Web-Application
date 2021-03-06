﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entry.aspx.cs" Inherits="WebApplication_SME.Entry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link rel="shortcut icon" href="/assets/ico/favicon.ico" />

    <title>Social Media Event</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <!-- Bootstrap theme -->
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
    <!-- Custom styles for this page -->
    <link href="Entry.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!-- Fixed navbar -->
            <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="Default.aspx">Social Media Event</a>
                    </div>
                    <div class="navbar-collapse collapse">
                        <ul class="nav navbar-nav">
                             <li><asp:HyperLink href="Registration.aspx" ID="RegMenu" runat="server">Registration</asp:HyperLink></li>
                            <li><a href="Loan.aspx">Loan Items</a></li>
                            <li class="active"><a href="Entry.aspx">Entry Control</a></li>
                            <li>
                                <asp:HyperLink href="Login.aspx" ID="LoginMenu" runat="server">Login</asp:HyperLink></li>
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>
            <div class="container">
                <h1>Entry Control</h1>
                <div class="lead">
                       <asp:TextBox ID="TextBox_persons" runat="server" Width="600px" Height="600px" TextMode="MultiLine" >                          
                           </asp:TextBox>
                </div>

                <div class="info">
                    <asp:TextBox ID="info" runat="server" Text="" Height="36px" Width="410px"></asp:TextBox>
                </div>

                <div class="entry">
                    <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="entry" runat="server" Text="Allow entry" OnClick="entry_Click" />
                </div>

                <div class="entry">
                    <asp:Panel CssClass="form-control alert alert-success" ID="Succes" runat="server" Visible="true">
                        <asp:Label ID="SuccesText" runat="server" Text="Entry allowed" />
                    </asp:Panel>
                </div>

                <div class="entry">
                    <asp:Panel CssClass="form-control alert alert-danger" ID="Unsuccess" runat="server" Visible="true">
                        <asp:Label ID="UnsuccesText" runat="server" Text="Entry denied" />
                    </asp:Panel>
                </div>


            </div>

        </div>
    </form>
    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
