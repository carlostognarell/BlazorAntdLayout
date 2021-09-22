using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BlazorAntDesignDemo.Data
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [DisplayName("Temp. (C)")]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public bool Hot { get; set; }
    }

    public class GridEntity<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
