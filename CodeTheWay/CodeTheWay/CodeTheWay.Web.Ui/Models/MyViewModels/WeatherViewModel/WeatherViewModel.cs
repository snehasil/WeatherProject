using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Controllers;

namespace CodeTheWay.Web.Ui.Models.MyViewModels.WeatherViewModel
{
    public class WeatherViewModel
    {
        public Guid Id { get; set; }
        public double HighTemp { get; set; }
        public double LowTemp { get; set; }
        public double AvgWindSpeed { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrecipitation { get; set; }
    }
}
    
