using System;

namespace TrainConfigurator
{
    public class Passenger
    {
        public int Count { get; private set; }
        public int Index { get; set; }

        public Passenger()
        {
            var random = new Random();
            Count = random.Next(100, 1001);
        }
    }
}