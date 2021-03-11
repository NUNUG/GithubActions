using System;
using System.Linq;
using WebApi.Controllers;
using Xunit;

namespace WebApi.Tests
{
	public class ApiTests
	{
		public WeatherForecastController Controller { get; set; }

		[Fact]
		public void Test1()
		{
			Controller = new WeatherForecastController(null);
			var result = Controller.Get();

			Assert.True(result != null);
			Assert.Equal(5, result.Count());
		}
	}
}
