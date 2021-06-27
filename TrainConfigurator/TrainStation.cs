using System;
using System.Collections.Generic;

namespace TrainConfigurator
{
    public class TrainStation
    {
        private const int RailwayCarriageCapacity = 54;
        private Train _train;
        private Passenger _passenger;

        public TrainStation()
        {
        }

        public string CreateDirection(string direction)
        {
            return $"Direction {direction} created";
        }

        private int SellTickets()
        {
            return _passenger.Count;
        }

        public void CreateTrain()
        {
            _passenger = new Passenger();
            int soldTickets = SellTickets();
            int railwayCarriageCount = 0;
            Console.WriteLine("Tickets sold: " + soldTickets);
            if (soldTickets <= RailwayCarriageCapacity)
                railwayCarriageCount = 1;
            else
                railwayCarriageCount = soldTickets / RailwayCarriageCapacity;
            Console.WriteLine("Railway carriage count: " + railwayCarriageCount);
            _train = new Train(railwayCarriageCount);
            _train.FormTrain(_passenger);
            Console.WriteLine("Train №" + _train.Index);
        }

        public string TrainDeparture(string direction)
        {
            return $"Train {_train.Index} departed, {direction}";
        }
    }
}