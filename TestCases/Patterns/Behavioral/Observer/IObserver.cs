// //IObserver.cs
// // Copyright (c) 2019 01 29All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Behavioral.Observer
{
    public interface IObserver
    {
        void NotifyStateChanged(string message);
    }
}