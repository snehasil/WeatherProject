using CodeTheWay.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CodeTheWay.Web.Ui.Services
{
    interface IWeatherService
    {
        public Task<Student> CreateWeather(Weather weather);

        public Task<List<Weather>> GetWeathers();
    }
}
