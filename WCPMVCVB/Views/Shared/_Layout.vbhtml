﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - WebClientPrint 6.0 for ASP.NET</title>
    
    <link rel="stylesheet" href="https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />

    @RenderSection("styles", required:=False)

    <style type="text/css">
        .navbar-custom {
            background-color: #244157;
            color: #ffffff;
            border-radius: 0;
        }

            .navbar-custom .navbar-nav > li > a {
                color: #fff;
            }

            .navbar-custom .navbar-nav > .active > a, .navbar-nav > .active > a:hover, .navbar-nav > .active > a:focus {
                color: #ffffff;
                background-color: transparent;
            }

            .navbar-custom .navbar-nav > li > a:hover, .nav > li > a:focus {
                text-decoration: none;
                background-color: #acdaee;
            }

            .navbar-custom .navbar-brand {
                color: #eeeeee;
            }

            .navbar-custom .navbar-toggle {
                background-color: #eeeeee;
            }

            .navbar-custom .icon-bar {
                background-color: #acdaee;
            }

            .round.white {
    background-color: #fff; color:#244157
}
.round {
    display: inline-block;
    height: 32px;
    width: 32px;
    line-height: 32px;
    -moz-border-radius: 16px;
    border-radius: 16px;
    background-color: #222;
    color: #FFF;
    text-align: center;
}

.icon {
    color:firebrick;
}
    </style>

</head>
<body>
    <div class="navbar navbar-default navbar-custom navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">
                    <img alt="Neodynamic" src="//www.neodynamic.com/images/webclientprinticon.png">
                </a>
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a href="//www.neodynamic.com/products/printing/raw-data/aspnet-mvc/download/" target="_blank" class="navbar-brand">WebClientPrint <span class="round white">6.0</span> for ASP.NET</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("Available Samples", "Samples", "Home")</li>
                    <li><a href="//www.neodynamic.com/products/printing/raw-data/aspnet-mvc/" target="_blank">About</a></li>
                </ul>
            </div>

            <div class="pull-right">
                <a class="btn btn-info" href="//github.com/neodynamic/WebClientPrint5-Sample" target="_blank"><i class="fa fa-github"></i> Source Code</a>
                <a class="btn btn-warning" href="//www.neodynamic.com/products/printing/raw-data/aspnet-mvc/download/" target="_blank"><i class="glyphicon glyphicon-download-alt"></i> Download SDK for ASP.NET</a>
            </div>
            <hr />
            <p>
                <small><em>Cross-browser Client-side Printing Solution for Windows, Linux, Mac & Raspberry Pi</em></small>
            </p>
        </div>
    </div>
    <div class="container body-content">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        @RenderBody()

        <footer>

            <br /><br /><br /><br /><hr />
            <p>
                <a href="//www.neodynamic.com/products/printing/raw-data/aspnet-mvc/" target="_blank">WebClientPrint for ASP.NET</a>
                &nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
                <i class="icon-user"></i> <a href="http://www.neodynamic.com/spport" target="_blank">Contact Tech Support</a>
            </p>
            <p>&copy; Copyright @DateTime.Now.Year - Neodynamic SRL<br />All rights reserved.</p>

        </footer>
    </div>


    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-2.2.0.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/bootstrap.min.js"></script>

    @RenderSection("scripts", required:=False)
</body>
</html>
