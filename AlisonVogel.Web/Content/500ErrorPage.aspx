﻿<% Response.StatusCode = 500 %>
<!DOCTYPE html>
<html>
<head>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="~/Content/alisonStyle.min.css" rel="stylesheet" />
    <link href="~/Content/font-awesome.min.css" rel="stylesheet" />
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-70100090-1', 'auto');
        ga('send', 'pageview');

    </script>
    <meta name="viewport" content="width=device-width" />
    <title>500 Error</title>
</head>
<body>
    <div class="container" style="text-align:center;">
        <br />
        <br />
        <h2>Oops! 500 Error page.</h2>
        <br />
        <br />
        <div>
           <!-- <a href='@Url.Action("Index", "Home")' class="btn btn-primary outline" role="button">Back to Home Page</a>-->
        </div>
        <br />
        <br />
    </div>
</body>
</html>


