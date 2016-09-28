using DesignPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer();
        }

        public static void Observer()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay =
                new CurrentConditionsDisplay(weatherData);
            // StatisticsDisplay staticsDisplay = new StatisticsDisplay(weatherData);
            // ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);
            Console.ReadKey();
        }
    }
}
