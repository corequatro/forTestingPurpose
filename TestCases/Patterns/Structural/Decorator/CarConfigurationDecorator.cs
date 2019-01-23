// //CarAccessoriesDecorator.cs
// // Copyright (c) 2019 01 23All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Structural.Decorator
{
    public class CarConfigurationDecorator : ICarShop
    {
        private readonly ICarShop _carShop;

        public CarConfigurationDecorator(ICarShop carShop)
        {
            _carShop = carShop;
        }

        public virtual string GetCarDescription()
        {
            return _carShop.GetCarDescription();
        }

        public virtual double GetCarPrice()
        {
            return _carShop.GetCarPrice();
        }
    }
}