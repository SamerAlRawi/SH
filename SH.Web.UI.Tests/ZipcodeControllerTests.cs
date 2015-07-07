using System.Collections.Generic;
using System.Web.Mvc;
using NUnit.Framework;
using SH.Business;
using SH.Web.UI.Controllers;
using NSubstitute;
using SH.Business.Models;

namespace SH.Web.UI.Tests
{
    public class ZipcodeControllerTests
    {
        private IZipCodesService _zipCodesService;
        private IWeatherService _weatherService;
        private ZipCodesController _controller;

        [SetUp]
        public void Init()
        {
            _zipCodesService = Substitute.For<IZipCodesService>();
            _weatherService = Substitute.For<IWeatherService>();
            _controller = new ZipCodesController(_zipCodesService, _weatherService);

        }

        [Test]
        public void Index_Returns_ZipCodes_from_ZipCodesService()
        {
            var expectedCodes = new List<ZipCode>{new ZipCode()};
            _zipCodesService.GetZipCodes().Returns(expectedCodes);
            var result = _controller.Index();

            Assert.That(result.Data, Is.EqualTo(expectedCodes));
        }


        [Test]
        public void GetWeather_Returns_Result_from_WeatherService()
        {
            var expectedWeatherResult = new WeatherResult();
            var  expectedZipCode = 1001;
            
            _weatherService.GetWeatherResult(expectedZipCode).Returns(expectedWeatherResult);
            
            var result = _controller.GetWeather(expectedZipCode);
            Assert.That(result.Data, Is.EqualTo(expectedWeatherResult));
        }


    }
}