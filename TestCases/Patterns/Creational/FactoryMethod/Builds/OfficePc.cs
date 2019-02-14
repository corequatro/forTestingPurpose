// //OfficePc.cs
// // Copyright (c) 2019 02 14All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using TestCases.Patterns.Creational.FactoryMethod.Components;

namespace TestCases.Patterns.Creational.FactoryMethod.Builds
{
    public class OfficePc : Computer
    {
        public override void CreateComputer()
        {
            Components.Add(new Cpu());
            Components.Add(new Hdd());
            Components.Add(new Motherboard());
        }
    }
}