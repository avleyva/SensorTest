<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SensorTest.WebForm1" %>

<!DOCTYPE html>
<!--<html xmlns="http://www.w3.org/1999/xhtml">-->
<html lang="en">
<head runat="server">
	<title>Simple Test for Sensor App</title>
	
	<link rel="stylesheet" href="css/styles.css" type="text/css" />
	<link rel="stylesheet" href="//cdn.datatables.net/1.10.2/css/jquery.dataTables.css">

	<!--<script src="Scripts/jquery-1.6.4.min.js"></script>-->
	<script src="Scripts/jquery-1.11.1.min.js"></script>
	<script src="Scripts/jquery.signalR-2.1.2.min.js"></script>
	<script src="signalr/hubs"></script>
	<script src="//cdn.datatables.net/1.10.2/js/jquery.dataTables.min.js"></script>
	<script src="Scripts/main.js"></script>
</head>
<body id="pageBody" runat="server">
	<div id="wrapper">
		<header><h1>Trek Bikes Sample Sensor</h1></header>
		<section id="Dashboard">
			<table id="dashboardTable" class="display">
				<thead>
					<tr>
						<th>Sensor #</th>
						<th>Sensor Name</th>
						<th>Sensor Description</th>
						<th>Is Monitored</th>
						<th>Current Value</th>
					</tr>
				</thead>
			</table>
		</section>
		<section id="UserInfo">
			<h3>Dashboard Info:</h3>
			<ul>
				<li>The dashboard shows active sensors only</li>
				<li>Values are updated near real-time</li>
			</ul>
		</section>
	</div>
</body>
</html>
