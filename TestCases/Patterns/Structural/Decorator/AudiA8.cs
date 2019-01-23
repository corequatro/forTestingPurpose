// //AudiA8.cs
// // Copyright (c) 2019 01 23All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Structural.Decorator
{
    public class AudiA8 : ICarShop
    {
        public string GetCarDescription()
        {
            return "AudiA8 basic";
        }

        public double GetCarPrice()
        {
            return 70000;
        }
    }
}