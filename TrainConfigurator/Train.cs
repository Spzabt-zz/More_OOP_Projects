using System;

namespace TrainConfigurator
{
    public class Train
    {
        private readonly int _railwayCarriageCapacity;
        private readonly int[][] _railwayCarriage;
        public string DirectionInfo { get; private set; }

        public Train(int railwayCarriageCount, int railwayCarriageCapacity, string directionInfo)
        {
            _railwayCarriage = new int[railwayCarriageCount][];
            _railwayCarriageCapacity = railwayCarriageCapacity;
            DirectionInfo = directionInfo;
        }

        public void FormTrain(Passenger passenger)
        {
            for (int i = 0; i < _railwayCarriage.Length; i++)
            {
                _railwayCarriage[i] = new int[_railwayCarriageCapacity];
            }

            for (int i = 0; i < _railwayCarriage.Length; i++)
            {
                Console.WriteLine($"\nrailway carriage number: {i}\n");
                for (int j = 0; j < _railwayCarriage[i].Length; j++)
                {
                    if (passenger.Index++ == passenger.Count)
                    {
                        return;
                    }
                    _railwayCarriage[i][j] = passenger.Index;
                    Console.WriteLine("Passenger number: " + passenger.Index);
                }
            }
        }

        public string RailwayCarriageCount()
        {
            return $"Railway carriage count: {_railwayCarriage.Length}";
        }
    }
}