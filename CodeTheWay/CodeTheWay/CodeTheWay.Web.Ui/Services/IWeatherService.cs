using CodeTheWay.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CodeTheWay.Web.Ui.Services
{
    public interface IWeatherService
    {
        public Task<Weather> Create(Weather weather);

        public Task<List<Weather>> GetWeathers();

        public Task<List<Weather>> GetWeathers(Guid id);

        public Task<Weather> Update(Weather weather);

        public Task<Weather> Delete(Weather weather);
    }
}
