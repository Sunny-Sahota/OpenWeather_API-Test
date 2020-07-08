using System.Collections.Generic;
using NUnit.Framework;
using WeatherAPI.CurrentWeatherService;

namespace WeatherAPI.Tests
{
	public class CWService_CityNameTest
	{
	
		private CWService _CWService = new CWService(cityName:"London");
		[Test]
		public void getBase_Success()
		{
			//write method to get id
			Assert.That(_CWService.getBase, Is.EqualTo("stations"));
		}

		[Test]
		public void APICall_Returns_Success()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.cod.ToString(), Is.EqualTo("200"));
		}

		[Test]
		public void CheckTimezone_Returns_CorrectTimeZone()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.timezone.ToString(), Is.EqualTo("3600"));
		}

		[Test]
		public void CheckPosition_Returns_CorrectLatitudeAndLongitude()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.coord.lon.ToString(), Is.EqualTo("-0.13"));
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.coord.lat.ToString(), Is.EqualTo("51.51"));
		}

		[Test]
		public void CheckCurrentID_ReturnsCorrectID()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.id.ToString(), Is.EqualTo("2643743")) ;

		}

		[Test]
		public void CheckCountry()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.sys.country.ToString(), Is.EqualTo("GB"));

		}

	}
}
