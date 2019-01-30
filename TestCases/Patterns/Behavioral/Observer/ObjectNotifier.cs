// //CurrencyChangeNotifier.cs
// // Copyright (c) 2019 01 30All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using System.Collections.Generic;


namespace TestCases.Patterns.Behavioral.Observer
{
    public class ObjectNotifier
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string info)
        {
            foreach (var observer in _observers)
            {
                observer.NotifyStateChanged(info);
            }
        }





    }
}