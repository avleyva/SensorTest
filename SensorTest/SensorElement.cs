using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SensorTest
{
	public class SensorElement
	{
		public int sensorId { get; set;}
		public String sensorName { get; set; }
		public String sensorDescription { get; set; }
		public Boolean isMonitored { get; set; }
		public String value { get; set; }
	}
}