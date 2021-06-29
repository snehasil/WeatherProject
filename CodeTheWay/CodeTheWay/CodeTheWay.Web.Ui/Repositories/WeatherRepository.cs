using CodeTheWay.Web.Ui.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private AppDbContext AppDbContext;

        public WeatherRepository(AppDbContext dbContext)
        {
            this.AppDbContext = dbContext;
        }
       /* public Task<Weather> Create(Weather weathers)
        {
            var result = await this.AppDbContext.Weather.AddAsync(weathers);
            await this.AppDbContext.Weather.SaveChangesAsync();

            return result.Entity;
        }
       */

    }
}
