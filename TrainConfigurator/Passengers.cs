using System;

namespace TrainConfigurator
{
    public class Passengers
    {
        public int Count { get; private set; }
        public int Index { get; set; }

        public Passengers()
        {
            var random = new Random();
            Count = random.Next(100, 1001);
        }
    }
}