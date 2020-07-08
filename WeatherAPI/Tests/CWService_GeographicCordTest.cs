using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherAPI.CurrentWeatherService;

namespace WeatherAPI.Tests
{
	public class CWService_GeographicCordTest
	{
		private CWService _CWService = new CWService(latitude: 35, longitude: 139);

		[Test]
		public void APICall_Returns_Success()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.cod.ToString(), Is.EqualTo("200"));
		}

		[Test]
		public void CheckCountry()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.sys.country.ToString(), Is.EqualTo("JP"));
		}

		[Test]
		public void CheckTimezone_Returns_CorrectTimeZone()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.timezone.ToString(), Is.EqualTo("32400"));
		}

		[Test]
		public void CheckPosition_Returns_CorrectLatitudeAndLongitude()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.coord.lon.ToString(), Is.EqualTo("139"));
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.coord.lat.ToString(), Is.EqualTo("35"));
		}

		[Test]
		public void CheckCurrentID_ReturnsCorrectID()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.id.ToString(), Is.EqualTo("1851632"));

		}

	}
}
