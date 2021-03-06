﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loan.aspx.cs" Inherits="WebApplication_SME.Loan" %>

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
    <link href="Loan.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
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
                        <li class="active"><a href="Loan.aspx">Loan Items</a></li>
                        <li><a href="Entry.aspx">Entry Control</a></li>
                        <li>
                            <asp:HyperLink href="Login.aspx" ID="LoginMenu" runat="server">Login</asp:HyperLink></li>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </div>
        <div class="container">
            <h1>Loan Items</h1>
            <p>Select the items you would like to loan for the event.</p>

            <div class="form-register">
                <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="RefreshList" runat="server" Text="Refresh List" OnClick="RefreshList_Click" />
            </div>

            <!-- Listbox -->
            <div class="lead">
                <asp:ListBox ID="lbox_Rentables" runat="server"></asp:ListBox>
            </div>

            <!--Add Item Button -->
            <div class="form-register">
                <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="btn_AddItem" runat="server" Text="Add Item" OnClick="btn_AddItem_Click" />
            </div>
            <!-- Item -->
            <div class="row">
                <div class="col-md-4">
                  <asp:TextBox ID="txt_Chosen1" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" Text="€"></asp:Label>
                    <asp:Label ID="Label9" runat="server" Text="0"></asp:Label>
                </div>
                <div class="remove">
                    <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="Remove1" runat="server" Text="X" Height="45px" Width="45px" OnClick="Remove1_Click" />
                </div>
            </div>
            <!-- Item -->
            <div class="row">
                <div class="col-md-4">
                   <asp:TextBox ID="txt_Chosen2" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="€"></asp:Label>
                    <asp:Label ID="Label8" runat="server" Text="0"></asp:Label>
                </div>
                <div class="remove">
                    <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="Remove2" runat="server" Text="X" Height="45px" Width="45px" OnClick="Remove2_Click" />
                </div>
            </div>
            <!-- Item -->
            <div class="row">
                <div class="col-md-4">
                    <asp:TextBox ID="txt_Chosen3" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                   
                    <asp:Label ID="Label3" runat="server" Text="€"></asp:Label>
                    <asp:Label ID="Label7" runat="server" Text="0"></asp:Label>
                </div>
                <div class="remove">
                    <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="Remove3" runat="server" Text="X" Height="45px" Width="45px" OnClick="Remove3_Click" />
                </div>
            </div>
            <!-- Item -->
            <div class="row">
                <div class="col-md-4">
                    <asp:TextBox ID="txt_Chosen4" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                   
                    <asp:Label ID="Label4" runat="server" Text="€"></asp:Label>
                    <asp:Label ID="Label10" runat="server" Text="0"></asp:Label>
                </div>
                <div class="remove">
                    <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="Remove4" runat="server" Text="X" Height="45px" Width="45px" OnClick="Remove4_Click" />
                </div>
            </div>
            <!-- Item -->
            <div class="row">
                <div class="col-md-4">
                    <asp:TextBox ID="txt_Chosen5" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
                   
                    <asp:Label ID="Label5" runat="server" Text="€"></asp:Label>
                    <asp:Label ID="Label6" runat="server" Text="0"></asp:Label>
                </div>
                <div class="remove">
                    <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="Remove5" runat="server" Text="X" Height="45px" Width="45px" OnClick="Remove5_Click" />
                </div>
            </div>

            <div class="label">
                <asp:Label ID="Totaal" runat="server" Text="Totaal: €"></asp:Label>
                 <asp:Label ID="Label11" runat="server" Text="0"></asp:Label>
            </div>
            <!--Finish Button -->
            <div class="form-register">
                <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="btn_Finish" runat="server" Text="Finish" OnClick="btn_Finish_Click" />
            </div>
        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
