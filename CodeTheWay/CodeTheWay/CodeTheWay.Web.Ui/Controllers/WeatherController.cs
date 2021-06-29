using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Controllers
{
    public class WeatherController : Controller
    {
        private IWeatherService WeatherService;
        public WeatherController(IWeatherService weatherService)
        {
            this.WeatherService = weatherService;
        }
        public async Task<IActionResult> Delete(Guid Id)
        {
            var weather = await WeatherService.GetWeathers(Id);
            await WeatherService.Delete(weather);
            return RedirectToAction("Index");
        }
    }

}
