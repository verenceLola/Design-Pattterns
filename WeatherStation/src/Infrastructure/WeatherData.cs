using WeatherStation.Interfaces;
using System.Collections.Generic;

namespace WeatherStation.Infrastructure
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        public float _temperature { get; private set; }
        public float _humidity { get; private set; }
        public float _pressure { get; private set; }
        public void registerObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        public void removeObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void notifyObservers()
        {
            _observers.ForEach(observer => observer.update());
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }
        public void setMeasurements(float temp, float pressure, float humidity)
        {
            _humidity = humidity;
            _temperature = temp;
            _pressure = pressure;
            measurementsChanged();
        }
    }
}
