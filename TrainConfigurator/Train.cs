using System;

namespace TrainConfigurator
{
    public class Train
    {
        private const int RailwayCarriageCapacity=54;
        private readonly int[][] _railwayCarriage;
        public int Index { get; private set; }

        public Train(int railwayCarriageCount/*int railwayCarriageCapacity,*/)
        {
            _railwayCarriage = new int[railwayCarriageCount][];
            //RailwayCarriageCapacity = railwayCarriageCapacity;
            Index++;
        }

        public void FormTrain(Passenger passenger)
        {
            for (int i = 0; i < _railwayCarriage.Length; i++)
            {
                _railwayCarriage[i] = new int[RailwayCarriageCapacity];
            }
            
            for (int i = 0; i < _railwayCarriage.Length; i++)
            {
                Console.WriteLine($"\nrailway carriage number: {i}\n");
                for (int j = 0; j < _railwayCarriage[i].Length; j++)
                {
                    _railwayCarriage[i][j] = passenger.Index++;
                    Console.WriteLine("Passenger number: " + passenger.Index);
                }
            }
        }
    }
}