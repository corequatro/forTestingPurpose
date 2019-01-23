// //PatternsTest.cs
// // Copyright (c) 2019 01 08All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using NUnit.Framework;
using TestCases.Patterns.Structural.Decorator;


namespace TestCases.Patterns.Structural
{
    public class StructuralPatternsTest
    {
        [Test]
        public void DecoratorTest_AddCarAccessories_CorrectPriceReturned()
        {
            var audiA8 = new AudiA8();
            var baseConfiguration = new CarConfigurationDecorator(audiA8);
            CarConfigurationDecorator extendedConfig = new EngineConfiguration(baseConfiguration,"5.0L");
            extendedConfig = new ExteriorConfiguration(extendedConfig, "red");
            var totalPrice = extendedConfig.GetCarPrice();
            var newConfig = extendedConfig.GetCarDescription();
            Assert.AreEqual(totalPrice,70150);
            Assert.AreEqual(newConfig, "AudiA8 basic5.0L red");
        }
    }
}