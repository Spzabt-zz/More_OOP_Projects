using System;
using System.Collections.Generic;

namespace TrainConfigurator
{
    public class Train
    {
        private readonly int _railwayCarriageCapacity;
        private List<RailwayCarriage> _railwayCarriages;
        private RailwayCarriage _railwayCarriage;
        // private readonly int[][] _railwayCarriage;
        public string DirectionInfo { get; private set; }

        public Train(int railwayCarriageCount, int railwayCarriageCapacity, string directionInfo)
        {
            _railwayCarriages = new List<RailwayCarriage>();
            // _railwayCarriage = new int[railwayCarriageCount][];
            _railwayCarriageCapacity = railwayCarriageCapacity;
            DirectionInfo = directionInfo;
        }

        public void FormTrain(Passengers passengers)
        {
            //_railwayCarriage=
            
            // for (int i = 0; i < _railwayCarriage.Length; i++)
            // {
            //     _railwayCarriage[i] = new int[_railwayCarriageCapacity];
            // }
            //
            // for (int i = 0; i < _railwayCarriage.Length; i++)
            // {
            //     Console.WriteLine($"\nrailway carriage number: {i}\n");
            //     for (int j = 0; j < _railwayCarriage[i].Length; j++)
            //     {
            //         if (passengers.Index++ == passengers.Count)
            //         {
            //             return;
            //         }
            //         _railwayCarriage[i][j] = passengers.Index;
            //         Console.WriteLine("Passenger number: " + passengers.Index);
            //     }
            // }
        }

        public string RailwayCarriageCount()
        {
            // return $"Railway carriage count: {_railwayCarriage.Length}";
            return String.Empty;
        }

        public void ShowInfo()
        {
            
        }
    }
}