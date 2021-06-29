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
        public async Task<Weather> Create(Weather weathers)
        
        public async Task<Weather> Delete(Weather model)
        {
            var result = await this.AppDbContext.Weathers.AddAsync(weathers);
            await this.AppDbContext.SaveChangesAsync();

            return result.Entity;
            AppDbContext.Weathers.Remove(model);
            await AppDbContext.SaveChangesAsync();
            return model;
        }

        public async Task<List<Weather>> GetWeathers()
        {
            return await this.AppDbContext.Weathers.ToListAsync();
        }
        public async Task<ShippingContainer> GetContainers(Guid id)
        {
            return await AppDbContext.ShippingContainer.FirstOrDefaultAsync(i => i.Id == id);
        }

    }
}
