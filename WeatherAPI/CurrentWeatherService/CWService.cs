using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherAPI.CurrentWeatherService.DataHandling;
using WeatherAPI.CurrentWeatherService.HTTPManager;

namespace WeatherAPI.CurrentWeatherService
{
	public class CWService
	{
		public CurrentWeatherCallManager _currentWeatherCallManager = new CurrentWeatherCallManager();
		public OpenWeatherDTO _openWeatherDTO = new OpenWeatherDTO();

		public string cityWeatherInfo;
		public JObject json_weather;

		public CWService(string cityName)
		{
			cityWeatherInfo=_currentWeatherCallManager.GetLatestWeather(cityName);
			_openWeatherDTO.DeserialiseCurrentWeather(cityWeatherInfo);
			json_weather = JsonConvert.DeserializeObject<JObject>(cityWeatherInfo);

		}

		public CWService(int cityID)
		{
			cityWeatherInfo = _currentWeatherCallManager.GetLatestWeatherWithCityID(cityID);
			_openWeatherDTO.DeserialiseCurrentWeather(cityWeatherInfo);
			json_weather = JsonConvert.DeserializeObject<JObject>(cityWeatherInfo);

		}

		public CWService(int latitude, int longitude)
		{
			cityWeatherInfo = _currentWeatherCallManager.GetLatestWeatherWithGeographicCoordinates(latitude, longitude);
			_openWeatherDTO.DeserialiseCurrentWeather(cityWeatherInfo);
			json_weather = JsonConvert.DeserializeObject<JObject>(cityWeatherInfo);

		}

		//public CWService(int lonLeft, int latBottom, int lonRight , int latTop, int zoom)
		//{
		//	cityWeatherInfo = _currentWeatherCallManager.GetLatestWeatherWithGeographicCoordinates(latitude, longitude);
		//	_openWeatherDTO.DeserialiseCurrentWeather(cityWeatherInfo);
		//	json_weather = JsonConvert.DeserializeObject<JObject>(cityWeatherInfo);

		//}

		public string getBase()
		{
			return json_weather["base"].ToString();
		}

	}
}
