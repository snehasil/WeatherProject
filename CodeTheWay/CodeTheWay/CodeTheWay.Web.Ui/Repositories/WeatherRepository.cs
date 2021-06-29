﻿using CodeTheWay.Web.Ui.Models;
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
        
        public async Task<Weather> Delete(Weather model)
        {
            AppDbContext.Weathers.Remove(model);
            await AppDbContext.SaveChangesAsync();
            return model;
        }
    }
}
