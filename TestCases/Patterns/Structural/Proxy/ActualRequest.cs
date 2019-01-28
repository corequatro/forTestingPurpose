// //ActualRequest.cs
// // Copyright (c) 2019 01 28All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Structural.Proxy
{
    public class ActualRequest : IActualRequest
    {
        public string GetAccountInfo()
        {
            return "original account info";
        }
    }
}