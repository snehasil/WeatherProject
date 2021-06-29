using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Models.MyViewModels.WeatherViewModel;
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
        public async Task<IActionResult> Index()
        {
            return View(await WeatherService.GetWeathers());
        }


        public async Task<IActionResult> Create()
        {
            return View(new WeatherViewModel());
        }
    }
}
