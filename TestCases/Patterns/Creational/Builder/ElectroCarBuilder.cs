// //ElectroCarBuilder.cs
// // Copyright (c) 2019 02 06All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Creational.Builder
{
    public class ElectroCarBuilder : VehicleBuilder
    {
        public ElectroCarBuilder()
        {
            vehicle = new Vehicle();
        }
        public override void BuildFrame()
        {
           
        }

        public override void BuildEngine()
        {
            vehicle.EngineType = "electro";
            vehicle.PetrolType = "electrics";
        }
    }
}