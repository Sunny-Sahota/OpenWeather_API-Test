using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WeatherAPI.CurrentWeatherService.HTTPManager
{
	public class CurrentWeatherCallManager
	{
		public readonly IRestClient client;

		public CurrentWeatherCallManager()
		{
			client = new RestClient(OpenWeatherConfigReader.BaseURL);
		}

		public string GetLatestWeather(string city)
		{
			var request = new RestRequest($"weather?q={city}&appid="+OpenWeatherConfigReader.ApiKey);
			var response = client.Execute(request, Method.GET);
			return response.Content;
		}

		public string GetLatestWeatherWithCityID(int cityId)
		{
			var request = new RestRequest($"weather?id={cityId}&appid=" + OpenWeatherConfigReader.ApiKey);
			var response = client.Execute(request, Method.GET);
			return response.Content;
		}

		public string GetLatestWeatherWithGeographicCoordinates(int latitude, int longitude)
		{
			var request = new RestRequest($"weather?lat={latitude}&lon={longitude}&appid=" + OpenWeatherConfigReader.ApiKey);
			var response = client.Execute(request, Method.GET);
			return response.Content;
		}
	}

}
