// //EngineConfigurationDecorator.cs
// // Copyright (c) 2019 01 23All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Structural.Decorator
{
    public class EngineConfiguration : CarConfigurationDecorator
    {
        private readonly string _engineType;
        public EngineConfiguration(ICarShop carShop, string engineType) : base(carShop)
        {
            _engineType = engineType;
        }
        public override string GetCarDescription()
        {
            return base.GetCarDescription() + _engineType;
        }

        public override double GetCarPrice()
        {
            return base.GetCarPrice() + 50;
        }

    }
}