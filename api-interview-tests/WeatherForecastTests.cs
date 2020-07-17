using api_interview.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace api_interview_tests
{
    [TestClass]
    public class WeatherForecastTests
    {
        [TestMethod]
        [Description("This method tests nothing at all")]
        public void WeatherForecastGet_ReturnsCorrectly()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            WeatherForecastController weatherForecastController = new WeatherForecastController(logger.Object);

            Assert.IsNotNull(weatherForecastController.Get());
        }
    }
}
