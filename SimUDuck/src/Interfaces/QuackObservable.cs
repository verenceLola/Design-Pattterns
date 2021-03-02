namespace SimUDuck.Interfaces
{
    public interface QuackObseravable
    {
        void registerObserver(Observer observer);
        void notifyObservers();
    }
}
