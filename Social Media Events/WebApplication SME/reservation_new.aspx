<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservation_new.aspx.cs" Inherits="WebApplication_SME.Reservation" %>

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
    <link href="reservation_new.css" rel="stylesheet" />

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
                        <a class="navbar-brand" href="index.aspx">Social Media Event</a>
                    </div>
                    <div class="navbar-collapse collapse">
                        <ul class="nav navbar-nav">
                            <li class="active"><a href="reservation_new.aspx">Reservation</a></li>
                            <li><a href="loan.aspx">Loan Items</a></li>
                            <li><a href="entry.aspx">Entry Control</a></li>
                            <li>
                                <asp:HyperLink ID="Login" runat="server" NavigateUrl="login.aspx">Login</asp:HyperLink></li>
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>
            <div class="container">
                <h1>Just a few steps.</h1>
                <p>Please fill in this form to register.</p>
                <!--Name -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Name</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="Name" type="text" runat="server" required="required" placeholder="John Doe" />
                    </div>
                </div>
                <!--Street -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Street</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="Street" type="text" runat="server" required="required" placeholder="Koningsstraat 9" />
                    </div>
                </div>
                <!--Postal-code -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Postal code</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="PostalCode" type="text" runat="server" required="required" placeholder="1234AB" />
                    </div>
                </div>
                <!--City -->
                <div class="row">
                    <div class="col-md-3">
                        <p>City</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="City" type="text" runat="server" required="required" placeholder="Amsterdam" />
                    </div>
                </div>
                <!--Telephone -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Phone number</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="Phone" type="tel" runat="server" required="required" placeholder="123-4567890" />
                    </div>
                </div>
                <!--Email -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Email address</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="Email" type="email" runat="server" required="required" placeholder="example@gmail.com" />
                    </div>
                </div>
                <!--Bank account number -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Bank account number</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="AccountNumber" type="number" runat="server" required="required" placeholder="123456789" />
                    </div>
                </div>
                <!--Social Security Number -->
                <div class="row">
                    <div class="col-md-3">
                        <p>Social Security Number</p>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="form-control" ID="SSN" type="number" runat="server" required="required" placeholder="123456789" />
                    </div>
                </div>
                <div class="form-register">
                    <asp:Button CssClass="btn btn-lg btn-primary btn-block" ID="Submit" Text="Register" runat="server" OnClick="Submit_Click" />
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
