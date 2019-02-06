// //PetrolCarBuilder.cs
// // Copyright (c) 2019 02 06All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Creational.Builder
{
    public class PetrolCarBuilder : VehicleBuilder
    {
        public PetrolCarBuilder()
        {
            vehicle = new Vehicle();
        }
        public override void BuildFrame()
        {
           
        }

        public override void BuildEngine()
        {
            vehicle.PetrolType = "gas";
            vehicle.EngineType = "v8";
        }
    }
}