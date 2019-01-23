// //ExteriorConfiguration.cs
// // Copyright (c) 2019 01 23All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Structural.Decorator
{
    public class ExteriorConfiguration : CarConfigurationDecorator
    {
        private readonly string _colorType;
        public ExteriorConfiguration(ICarShop carShop, string colorType) : base(carShop)
        {
            _colorType = colorType;
        }

        public override string GetCarDescription()
        {
            return base.GetCarDescription() + " " + _colorType;
        }

        public override double GetCarPrice()
        {
            return base.GetCarPrice() + 100;
        }
    }
}