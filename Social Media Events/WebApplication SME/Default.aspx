<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication_SME.Index" %>

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
    <link href="Default.css" rel="stylesheet" />
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
                            <li><a href="Entry.aspx">Entry Control</a></li>
                            <li>
                                <asp:HyperLink href="Login.aspx" ID="LoginMenu" runat="server">Login</asp:HyperLink></li>
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>
            <!-- Carousel
    ================================================== -->
            <div id="myCarousel" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                </ol>
                <div class="carousel-inner">
                    <div class="item active">
                        <img src="/images/test.jpg" alt="First slide"/>
                        <div class="container">
                            <div class="carousel-caption">
                                <h1>Welcome on our Website</h1>
                                <p>If you are here for reserving a camping spot please go to the registration tab. Otherwise sign in with your account</p>
                                  <p><asp:Button ID="Register" class="btn btn-lg btn-primary"  runat="server" href="Registration.aspx" Text="Register" /></p>                
                            </div>
                        </div>
                    </div>
                    <div class="item">
                       <img src="/images/test.jpg" alt="Second slide"/>
                        <div class="container">
                            <div class="carousel-caption">
                                <h1>Welcome on our Website</h1>
                                <p>If you want to loan items which are going to be used on the camping, go to the loan tab. Please make sure you are signed in</p>
                                <p><a class="btn btn-lg btn-primary" href="Loan.aspx" role="button">Loan Items</a></p>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <img src="/images/test.jpg" alt="Third slide"/>
                        <div class="container">
                            <div class="carousel-caption">
                                <h1>Welcome on our Website</h1>
                                <p>Only administrators can take a look at the entry control page. Please sign in as a administrator to do so</p>
                                <p><a class="btn btn-lg btn-primary" href="entry.aspx" role="button">Entry control</a></p>
                            </div>
                        </div>
                    </div>
                </div>
                <a class="left carousel-control" href="#myCarousel" data-slide="prev"><span class="glyphicon glyphicon-chevron-left"></span></a>
                <a class="right carousel-control" href="#myCarousel" data-slide="next"><span class="glyphicon glyphicon-chevron-right"></span></a>
            </div>
            <!-- /.carousel -->
        </div>
    </form>
    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
