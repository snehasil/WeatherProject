using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models.MyViewModels;
using CodeTheWay.Web.Ui.Models.MyViewModels.WeatherViewModel;

namespace CodeTheWay.Web.Ui.Controllers
{
    public class WeatherController : Controller
    {
        
        public IActionResult Index()
        {
            return View(await WeatherService.getWeathers());
        }
        

        public async Task<IActionResult> Create()
        {
            return View(new WeatherViewModel());
        }
        [HttpPost]

       
        public async Task<IActionResult> Register(WeatherViewModel model)
        {
         
      
            if (ModelState.IsValid)
            {
               
                if (model.AvgWindSpeed > 0)
                {
                   
                        Weather listofDays = new Weather()
                        {
                            Id = model.Id,
                            LowTemp = model.LowTemp,
                            HighTemp = model.HighTemp,
                            AvgWindSpeed = model.AvgWindSpeed,
                            Date = model.Date,
                            TotalPrecipitation = model.TotalPrecipitation


                        };

                        return RedirectToAction("Index");
                    
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
                
                    return View("model");
                
        }//end of register method
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id)
        {
            var weather = await WeatherService.getWeather(id);
            WeatherViewModel temp = new WeatherViewModel()
            {
             Id = temp.Id,
               LowTemp = temp.LowTemp,
               HighTemp = temp.HighTemp,
               AvgWindSpeed = temp.AvgWindSpeed,
               Date = temp.Date,
               TotalPrecipitation = temp.TotalPrecipitation 
            };
            return View(temp);
        }//end of edit method
        [HttpPost]
        public async Task<IActionResult> Update(Weather model)               
        {
            if (ModelState.IsValid)
            {
                if (model.AvgWindSpeed > 0 )
                {
                    Weather list = new Weather()
                    {
                       Id = model.Id,
                            LowTemp = model.LowTemp,
                            HighTemp = model.HighTemp,
                            AvgWindSpeed = model.AvgWindSpeed,
                            Date = model.Date,
                            TotalPrecipitation = model.TotalPrecipitation 
                    };
                    var weather = await WeatherService.Update(list);
                }


                return RedirectToAction("Index");
                
            }
            return View(model);
        }//end of update method
        }
                
            
        }
    

