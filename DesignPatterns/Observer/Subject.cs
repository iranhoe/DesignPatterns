using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoverObserver(Observer o);
        void NotifyObservers();
    }

    public interface Observer
    {
        void Update(float temperature, float humidity, float pressure);
    }

    public interface DisplayElement
    {
        void Display();
    }
}
