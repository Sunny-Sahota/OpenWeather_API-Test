using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAPI.CurrentWeatherService.DataHandling
{
	
	public class OpenWeatherDTO //Data transfer Object
	{
		public CurrentWeatherModel CurrentWeather { get; set; }

		public void DeserialiseCurrentWeather(string CurrentWeatherResponse) 
		{
			CurrentWeather = JsonConvert.DeserializeObject<CurrentWeatherModel>(CurrentWeatherResponse);
		}
	}
}
