// //Computer.cs
// // Copyright (c) 2019 02 14All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using System.Collections.Generic;

namespace TestCases.Patterns.Creational.FactoryMethod
{
    public abstract class Computer
    {
        private List<Component> _components = new List<Component>();

        public Computer()
        {
            this.CreateComputer();
        }

        public abstract void CreateComputer();

        public List<Component> Components => _components;

    }
}