using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Services
{
    public class WeatherService
    {
        private IWeatherRepository WeatherRepo;

        public WeatherService(AppDbContext dbContext)
        {
            this.WeatherRepo = new WeatherRepository(dbContext);
        }

       public async Task<Weather> CreateWeather(Weather weather)
        {
            return await this.WeatherRepo.Create(weather);
        }
        public async Task<List<Weather>> GetWeathers()
        {
            return await this.WeatherRepo.GetWeathers();
        }

         
        public async Task<Weather> Update(Weather weather)
        {
            return await WeatherRepo.Update(weather);
        }
       
    }
}
