using System;
using System.Collections.Generic;

namespace TrainConfigurator
{
    public class TrainStation
    {
        private readonly List<Train> _trains;
        private readonly List<string> _directions;
        private Train _train;
        private Passenger _passenger;
        private const int RailwayCarriageCapacity = 54;

        public TrainStation()
        {
            _trains = new List<Train>();
            _directions = new List<string>();
        }

        private string CreateDirection(string direction)
        {
            _directions.Add(direction);
            return direction;
        }

        private int SellTickets()
        {
            return _passenger.Count;
        }

        public void CreateTrain(string direction)
        {
            var rand = new Random();
            _passenger = new Passenger();
            int soldTickets = SellTickets();
            Console.WriteLine("Tickets sold: " + soldTickets);
            var railwayCarriageCount = Math.Round((double) (soldTickets / RailwayCarriageCapacity),
                MidpointRounding.AwayFromZero);
            railwayCarriageCount++;
            Console.WriteLine("Railway carriage count: " + railwayCarriageCount);
            _train = new Train((int)railwayCarriageCount, RailwayCarriageCapacity, CreateDirection(direction));
            _train.FormTrain(_passenger);
            Console.WriteLine($"Train direction: {_train.DirectionInfo}");
        }

        public void TrainDeparture()
        {
            _trains.Add(_train);
            int index = 0;
            foreach (var train in _trains)
            {
                Console.SetCursorPosition(50, index);
                Console.WriteLine($"Train departed, direction: {train.DirectionInfo}, {train.RailwayCarriageCount()}");
                index++;
            }
        }
    }
}