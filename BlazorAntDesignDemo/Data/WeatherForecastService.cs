using AntDesign.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAntDesignDemo.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        //{
        //    var rng = new Random();
        //    return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = startDate.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    }).ToArray());
        //}

        public Task<GridEntity<WeatherForecast>> GetForecastAsync(int pageIndex, int pageSize, QueryModel<WeatherForecast> queryModel)
        {
            var forcastList = GetWeatherForecasts();
            var totalcount = forcastList.Count;

            foreach (var sort in queryModel.SortModel)
            {
                if(sort.SortType != null)
                {
                    if (sort.SortType.Name == "ascend")
                    {
                        forcastList = forcastList.OrderBy(o=> this.GetPropValue(o,sort.FieldName)).ToList();
                    }
                    else if (sort.SortType.Name == "descend")
                    {
                        forcastList = forcastList.OrderByDescending(o => this.GetPropValue(o, sort.FieldName)).ToList();
                    }
                }
            }
            forcastList = forcastList.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            GridEntity<WeatherForecast> list = new GridEntity<WeatherForecast>();
            list.Items = forcastList;
            list.TotalCount = totalcount;
            return Task.FromResult(list);
        }

        public object GetPropValue(object src,string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src,null);
        }

      
        public List<WeatherForecast> GetWeatherForecasts()
        {
            var rnd = new Random();

            var forcastList = new List<WeatherForecast>();
            for (int i = 1; i <= 10000; i++)
            {
                forcastList.Add(new WeatherForecast()
                {
                    Id = i,
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rnd.Next(-20, 55),
                    Summary = Summaries[rnd.Next(Summaries.Length)],
                    Hot = rnd.Next(-20, 55) > 30
                });
            }

            return forcastList;
        }

    }
}
