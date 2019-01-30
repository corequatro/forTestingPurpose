// //PatternsTest.cs
// // Copyright (c) 2019 01 08All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using NUnit.Framework;
using TestCases.Patterns.Behavioral.Observer;

namespace TestCases.Patterns.Behavioral
{
    public class BehavioralPatternsTest
    {

        [Test]
        public void ObserverTest_NotifyUsersOfMessageChange_AllUsersAreNotified()
        {
            var currencyChangeNotifier = new ObjectNotifier();
            var billyGates = new Observer.Observer("Bil Gates");
            var satyaNadella = new Observer.Observer("Satya Nadella");
            currencyChangeNotifier.AddObserver(billyGates);
            currencyChangeNotifier.AddObserver(satyaNadella);
            currencyChangeNotifier.NotifyObservers("$ rises");
            Assert.AreEqual(billyGates.Message, "Bil Gates $ rises");
            Assert.AreEqual(satyaNadella.Message, "Satya Nadella $ rises");
        }
    }
}