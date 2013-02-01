

namespace PrismApp.Modules.MyFirstModule.Services
{
    using System;
    public class NameService : INameService
    {
        private readonly string[] _texts = { "Jalal", "Majid", "Saeed", "Alireza", "Esmaeil" };
        private readonly Random _random = new Random();

        public string GetRandomName()
        {
            // return random name...
            return _texts[_random.Next(0, _texts.Length)];
        }
    }
}
