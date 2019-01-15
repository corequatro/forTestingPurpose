// //Dog.cs
// // Copyright (c) 2019 01 15All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Creational.Prototype
{
    public class Dog : IAnimal
    {
        public string DogColor { get; set; }
        public int LegQuantity { get; set; }

        public IAnimal CloneAnimal()
        {
            return (Dog)MemberwiseClone();
        }
    }
}