$(function () {
	var conn = $.connection("https://sensorsource.azurewebsites.net/sensor/readings");
	conn.start({ transport: ['webSockets', 'longPolling'] });
	conn.received(function (data) {
		updateSensorValue(data.SensorId, data.Value);
	});
});

function updateSensorValue(sensorId, newValue) {
	$('table tbody tr').each(function (i) {
		if ($(this).children('td')[0].innerText == sensorId) {
			var valTmp = (newValue * 100).toFixed(2);
			$(this).children('td')[3].innerText = valTmp + '%';
			if (valTmp < 70)
				$(this).children('td')[3].style.backgroundColor = '#FF3300';
			else if (valTmp >= 70 && valTmp < 80)
				$(this).children('td')[3].style.backgroundColor = '#FFFF00';
			else
				$(this).children('td')[3].style.backgroundColor = '#009900';
		}
	});
}

$(document).ready(function () {
	$('#dashboardTable').dataTable({
		"ajax": 'Sensor.aspx',
		"columns": [
			{ "data": "sensorId" },
			{ "data": "sensorName" },
			{ "data": "sensorDescription" },
			{ "data": "isMonitored" },
			{ "data": "value" }
		],
		"columnDefs": [
			{
				"targets": [3],
				"visible": false,
				"searchable": false
			}
		],
		"paging": false,
		"info": false,
		"searching": false
	});
});
