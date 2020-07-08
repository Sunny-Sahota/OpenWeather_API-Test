
using NUnit.Framework;
using WeatherAPI.CurrentWeatherService;

namespace WeatherAPI.Tests
{
	public class CWService_CityIDTest
	{
		//2172797    //Cairns Australia

		private CWService _CWService = new CWService(2172797);

		[Test]
		public void APICall_Returns_Success()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.cod.ToString(), Is.EqualTo("200"));
		}

		[Test]
		public void CheckCityName()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.name.ToString(), Is.EqualTo("Cairns"));

		}

		[Test]
		public void CheckCountry()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.sys.country.ToString(), Is.EqualTo("AU"));

		}

		[Test]
		public void CheckTimezone_Returns_CorrectTimeZone()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.timezone.ToString(), Is.EqualTo("36000"));
		}

		[Test]
		public void CheckPosition_Returns_CorrectLatitudeAndLongitude()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.coord.lon.ToString(), Is.EqualTo("145.77"));
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.coord.lat.ToString(), Is.EqualTo("-16.92"));
		}

		[Test]
		public void CheckCurrentID_ReturnsCorrectID()
		{
			Assert.That(_CWService._openWeatherDTO.CurrentWeather.id.ToString(), Is.EqualTo("2172797"));

		}

		
	}
}
