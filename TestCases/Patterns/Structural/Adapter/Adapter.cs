// //Adapter.cs
// // Copyright (c) 2019 01 27All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Structural.Adapter
{
    public class Adapter : IAdapter
    {
        private readonly LegacyLib _legacyLib;
        public Adapter()
        {
            _legacyLib = new LegacyLib();
        }

        public string Hello()
        {
            return _legacyLib.SayLegacyHello();
        }

        public void DoNothing()
        {
            _legacyLib.DoNothing();
        }
    }
}