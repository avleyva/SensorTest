using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;


namespace SensorTest
{
	public partial class Sensor : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			List<SensorElement> arrElements = new List<SensorElement>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Data Source=hrr4eyxqec.database.windows.net;Initial Catalog=SensorSource;User ID=SensorReader;Password=P}Sd8df&sdf5{sdf0f|>;";
			conn.Open();			
			SqlCommand cmd = new SqlCommand("SELECT * FROM Sensors", conn);
			SqlDataReader readerTmp = cmd.ExecuteReader();
			while (readerTmp.Read())
			{
				if (Boolean.Parse(readerTmp["IsMonitored"].ToString()) == true)
				{
					SensorElement elementTmp = new SensorElement
					{
						sensorId = int.Parse(readerTmp["ID"].ToString()),
						sensorName = readerTmp["Name"].ToString(),
						sensorDescription = readerTmp["Description"].ToString(),
						isMonitored = Boolean.Parse(readerTmp["IsMonitored"].ToString()),
						value = ""
					};
					arrElements.Add(elementTmp);
				}
			}
			
			readerTmp.Close();
			conn.Close();
			Response.ContentType = "application/json";
			Response.Write("{");
			Response.Write('"');
			Response.Write("data");
			Response.Write('"');
			Response.Write(":" + JsonConvert.SerializeObject(arrElements));
			Response.Write("}");
			Response.End();
		}
	}
}