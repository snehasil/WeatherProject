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
        public IActionResult Index()
        {
            return View(await WeatherViewModel.GetWeathers());
        }
        

        public async Task<IActionResult> Create()
        {
            return View(new WeatherViewModel());
        }
        [HttpPost]
    }
}
