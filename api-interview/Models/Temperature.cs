using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_interview.Models
{
    public class Temperature
    {
        private readonly double _temp;
        private readonly DateTime _date;

        public Temperature (double temp, DateTime date)
        {
            _temp = Math.Round(temp);
            _date = date;
        }

        public double TemperatureC { get { return _temp;} }

        public DateTime Date { get { return _date; } }
    }
}
