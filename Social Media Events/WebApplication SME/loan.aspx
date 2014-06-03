<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loan.aspx.cs" Inherits="WebApplication_SME.Loan" %>

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
                        <li class="active"><a href="Loan.aspx">Loan Items</a></li>
                        <li><a href="Entry.aspx">Entry Control</a></li>
                        <li>
                            <asp:HyperLink href="Login.aspx" ID="LoginMenu" runat="server">Login</asp:HyperLink></li>
                    </ul>
                </div>
            </div>
        </div>
        <div id="label" class="container ">
            <asp:Label ID="label1" runat="server" />
        </div>
        <br />
    <br />
    <br />
    <br />
        <p class="lead">
            <asp:ListBox ID="lbox_Rentables" runat="server">
                <asp:ListItem>TestItem01</asp:ListItem>
                <asp:ListItem>TestItem02</asp:ListItem>
            </asp:ListBox>
&nbsp;
            <asp:Button ID="btn_AddItem" runat="server" Text="Toevoegen" />
        </p>
        <p class="lead">
            <asp:TextBox ID="txt_Chosen1" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
                <asp:ListItem Value="4"></asp:ListItem>
                <asp:ListItem Value="5"></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:TextBox ID="txt_Chosen2" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
                <asp:ListItem Value="4"></asp:ListItem>
                <asp:ListItem Value="5"></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:TextBox ID="txt_Chosen3" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
                <asp:ListItem Value="4"></asp:ListItem>
                <asp:ListItem Value="5"></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:TextBox ID="txt_Chosen4" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;
            <asp:DropDownList ID="DropDownList4" runat="server">
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
                <asp:ListItem Value="4"></asp:ListItem>
                <asp:ListItem Value="5"></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:TextBox ID="txt_Chosen5" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;
            <asp:DropDownList ID="DropDownList5" runat="server">
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
                <asp:ListItem Value="4"></asp:ListItem>
                <asp:ListItem Value="5"></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:Button ID="btn_Finish" runat="server" Text="Voltooien" />
        </p>

    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
