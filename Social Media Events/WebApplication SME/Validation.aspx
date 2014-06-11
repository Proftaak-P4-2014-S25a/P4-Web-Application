<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="WebApplication_SME.validate" %>

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
    <link href="Validation.css" rel="stylesheet" />
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
                            <li><a href="Registration.aspx">Registration</a></li>
                            <li><a href="Loan.aspx">Loan Items</a></li>
                            <li><a href="Entry.aspx">Entry Control</a></li>
                            <li>
                                <asp:HyperLink ID="Login" runat="server" NavigateUrl="Login.aspx">Login</asp:HyperLink></li>
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>
            <div class="container">
                <h1 class="form-register-heading" style="color: green;">Email validated.</h1>
                <h2 class="form-register-heading">Please choose your campsite</h2>
                <!--Campsite -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Campsite</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox style="width: 50%; float: left;" CssClass="form-control" ID="tb_CampSite" type="number" runat="server" required="required" placeholder="321"/>
                        <asp:Label style="width: 30px; float:right; margin: 0px;" CssClass="form-control alert alert-success" ID="GoodCampsite" runat="server" Text="&#x2713;" />
                    </div>
                  <div class="lbox">
                <asp:ListBox ID="lbox_Spots" runat="server" >                 
                </asp:ListBox>
            </div>
                </div>
                <!--Number of members attending -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Number of members attending</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="tb_Members" type="number" runat="server" required="required" placeholder="3" />
                    </div>
                </div>
                <div class="form-register">
                    <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="Submit" Text="Submit" runat="server" OnClick="Submit_Click" />
                </div>
                <asp:Label runat="server" ID="EmailSent" Style="margin-top: 50px; font-size: 16px;" Text="An email with login details has been sent to: " />
            </div>
        </div>
    </form>
</body>
</html>
