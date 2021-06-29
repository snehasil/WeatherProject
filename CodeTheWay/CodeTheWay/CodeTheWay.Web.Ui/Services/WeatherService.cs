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

         public async Task<List<Weather>> GetWeathers(Guid id)
         {
             return await this.WeatherRepo.GetWeathers();
         }
        
        public async Task<Weather> Delete(Weather weather)
        {
            return await WeatherRepo.Delete(weather);
        }
    }
}
