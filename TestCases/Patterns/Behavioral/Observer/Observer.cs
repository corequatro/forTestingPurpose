// //Observer.cs
// // Copyright (c) 2019 01 30All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Behavioral.Observer
{
    public class Observer : IObserver
    {
        private readonly string _observerName;
        public string Message { get; set; }
        public Observer(string observerName)
        {
            _observerName = observerName;
        }
        public void NotifyStateChanged(string message)
        {
            Message = $"{_observerName} {message}";
        }
    }
}