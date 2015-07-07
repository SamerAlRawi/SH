using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SH.Business.Tests
{
    [TestFixture]
    public class WeatherServiceTests
    {
        private WeatherService _weatherService;
        [SetUp]
        public void Init()
        {
            _weatherService = new WeatherService();
        }

        [Test]
        public void CallsWithCorrectUrl()
        {
            //fake webclient and verify the result
        }
    }
}
