<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YcHighCharts.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-1.5.1.min.js" type="text/javascript"></script>
    <script src="Highcharts-3.0.9/js/highcharts.js" type="text/javascript"></script>
    <script src="Highcharts-3.0.9/js/modules/exporting.js" type="text/javascript"></script>
    <script src="Highcharts-3.0.9/js/highcharts-more.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <%=chartJs %>
    <div id='canvasDiv'>
    </div>
    <div id='canvasDiv1'>
    </div>
    <div id='canvasDiv2'>
    </div>
    <div id='canvasDiv3'>
    </div>
    <div id='canvasDiv4'>
    </div>
    <div id='canvasDiv5'>
    </div>
    </form>
</body>
</html>
