
using System;
using WeatherStation.Interfaces;

namespace WeatherStation.Infrastructure
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public void display()
        {
            Console.WriteLine($"Current condtions: {_temperature} F degrees and {_humidity} % humidity");
        }
        public void update()
        {
            _temperature = _weatherData._temperature;
            _humidity = _weatherData._humidity;
            display();
        }
        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.registerObserver(this);
        }
        public void unRegister()
        {
            _weatherData.removeObserver(this);
        }
    }
}
