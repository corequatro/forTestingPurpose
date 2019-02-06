// //VehicleBuilder.cs
// // Copyright (c) 2019 02 06All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Creational.Builder
{
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public Vehicle Vehicle => vehicle;
    }
}