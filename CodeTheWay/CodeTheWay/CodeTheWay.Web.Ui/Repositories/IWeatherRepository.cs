using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;
namespace CodeTheWay.Web.Ui.Repositories
{
    interface IWeatherRepository
    {
      public Task<Weather> Create(Weather Weathers);

      public Task<List<Weather>> GetWeathers();

        public Task<Weather> Delete(Weather model);
    }
}
