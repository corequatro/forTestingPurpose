// //RequestProxy.cs
// // Copyright (c) 2019 01 28All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Structural.Proxy
{
    public class RequestProxy : IActualRequest
    {
        private readonly ActualRequest _actualRequest = new ActualRequest();
        public string GetAccountInfo()
        {
            return _actualRequest.GetAccountInfo() + "extra data";
        }
    }
}