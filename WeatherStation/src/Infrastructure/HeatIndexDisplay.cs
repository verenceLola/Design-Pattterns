using System;
using WeatherStation.Interfaces;


namespace WeatherStation.Infrastructure
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private float _temperature, _humidity;
        private WeatherData _weatherData;
        public void update()
        {
            _temperature = _weatherData._temperature;
            _humidity = _weatherData._humidity;
            display();
        }
        public float calculateHeatIndex() => _temperature * _humidity;
        public void display()
        {
            Console.WriteLine($"Heat index is {calculateHeatIndex()}");
        }
        public HeatIndexDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.registerObserver(this);
        }
    }
}
