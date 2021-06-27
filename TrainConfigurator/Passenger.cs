using System;

namespace TrainConfigurator
{
    public class Passenger
    {
        private Random _random;
        public int Count { get; private set; }
        public int Index { get; set; }

        public Passenger()
        {
            _random = new Random();
            Count = _random.Next(1001);
        }
    }
}