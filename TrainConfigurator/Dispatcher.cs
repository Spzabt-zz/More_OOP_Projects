using System;
using System.Collections.Generic;

namespace TrainConfigurator
{
    public class Dispatcher
    {
        private readonly List<Train> _trains;
        private Train _train;
        private Passengers _passengers;
        private const int RailwayCarriageCapacity = 54;

        public Dispatcher()
        {
            _trains = new List<Train>();
        }

        private string CreateDirection()
        {
            string direction = Console.ReadLine();
            return direction;
        }

        private int SellTickets()
        {
            return _passengers.Count;
        }

        public void CreateTrain()
        {
            _passengers = new Passengers();
            Console.WriteLine("Задайте маршрут");
            string direction = CreateDirection();
            int soldTickets = SellTickets();
            Console.WriteLine("Tickets sold: " + soldTickets);
            var railwayCarriageCount = Math.Round((double) (soldTickets / RailwayCarriageCapacity),
                MidpointRounding.AwayFromZero);
            railwayCarriageCount++;
            Console.WriteLine("Railway carriage count: " + railwayCarriageCount);
            _train = new Train((int)railwayCarriageCount, RailwayCarriageCapacity, direction);
            _train.FormTrain(_passengers);
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