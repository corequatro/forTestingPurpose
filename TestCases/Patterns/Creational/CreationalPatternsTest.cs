﻿// //PatternsTest.cs
// // Copyright (c) 2019 01 08All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using System;
using NUnit.Framework;
using TestCases.Patterns.Creational.AbstractFactory;
using TestCases.Patterns.Creational.AbstractFactory.ElectroCars.Tesla;
using TestCases.Patterns.Creational.AbstractFactory.GasCars.Audi;
using TestCases.Patterns.Creational.Builder;
using TestCases.Patterns.Creational.FactoryMethod;
using TestCases.Patterns.Creational.FactoryMethod.Builds;
using TestCases.Patterns.Creational.Prototype;

namespace TestCases.Patterns.Creational
{
    public class CreationalPatternsTest
    {
        [Test]
        public void AbstractFactoryTest_BuildElectroAndGasCars_CorrectTypeOfCarsAreCreated()
        {
            var teslaClient = new CarClient(new TeslaFactory());
            var model3 = teslaClient.GetFactory.BuildElectroCar(new Model3());
            var modelS = teslaClient.GetFactory.BuildElectroCar(new ModelS());
            Assert.AreEqual(typeof(Model3).FullName, model3.GetType().FullName);
            Assert.IsFalse(model3.CarId == Guid.Empty);
            Assert.AreEqual(typeof(ModelS).FullName, modelS.GetType().FullName);
            Assert.IsFalse(modelS.CarId == Guid.Empty);

            var audiClient = new CarClient(new AudiFactory());
            var audiA8 = audiClient.GetFactory.BuildGasCar(new AudiA8());
            Assert.AreEqual(typeof(AudiA8).FullName, audiA8.GetType().FullName);
            Assert.IsFalse(audiA8.CarId == Guid.Empty);
        }


        [Test]
        public void BuilderPatternTest_BuildElectroAndGasCars_CorrectVehicleTypeAreCreated()
        {
            var carShop = new CarShop();
            VehicleBuilder builder = new ElectroCarBuilder();
            carShop.Construct(builder);
            Assert.AreEqual(builder.Vehicle.EngineType, "electro");
            Assert.AreEqual(builder.Vehicle.PetrolType, "electrics");
            builder = new PetrolCarBuilder();
            carShop.Construct(builder);
            Assert.AreEqual(builder.Vehicle.EngineType, "v8");
            Assert.AreEqual(builder.Vehicle.PetrolType, "gas");
        }


        [Test]
        public void PrototypePatternTest_CloneAnimals_CorrectTypesOfAnimalsCloned()
        {
            var sheep = new Sheep { LegQuantity = 10, SheepColor = "Black" };
            var sheepClone = (Sheep)sheep.CloneAnimal();
            Assert.AreEqual(sheep.LegQuantity, sheepClone.LegQuantity);
            Assert.AreEqual(sheep.SheepColor, sheepClone.SheepColor);
            Assert.AreEqual(typeof(Sheep).FullName, sheepClone.GetType().FullName);
            var dog = new Dog { LegQuantity = 10, DogColor = "Black" };
            var dogClone = (Dog)dog.CloneAnimal();

            Assert.AreEqual(dog.LegQuantity, dogClone.LegQuantity);
            Assert.AreEqual(dog.DogColor, dogClone.DogColor);
            Assert.AreEqual(typeof(Dog).FullName, dogClone.GetType().FullName);
        }

        [Test]
        public void FactoryMethodPatternTest_CreateComputers_CorrectTypesOfComputersWithComponentsCreated()
        {
            var computers = new Computer[2];
            computers[0] = new PowerPc();
            computers[1] = new OfficePc();
            Assert.AreEqual(computers[0].Components.Count, 4);
            Assert.AreEqual(computers[1].Components.Count, 3);
        }
    }
}