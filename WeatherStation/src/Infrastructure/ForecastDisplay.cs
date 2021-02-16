using System;
using WeatherStation.Interfaces;


namespace WeatherStation.Infrastructure
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _pressure;
        private WeatherData _weatherData;
        public void display()
        {
            Console.WriteLine(_pressure > 10 ? "Mostly Calm" : "Mostly Windy");
        }
        public void update()
        {
            _pressure = _weatherData._pressure;
            display();
        }
        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.registerObserver(this);
        }
    }
}
