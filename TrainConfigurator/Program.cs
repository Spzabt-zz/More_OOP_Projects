using System;

namespace TrainConfigurator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TrainStation trainStation = new TrainStation();
            Console.WriteLine("Задайте маршрут");
            string direction = Console.ReadLine();
            Console.WriteLine(trainStation.CreateDirection(direction));
            trainStation.CreateTrain();
            Console.WriteLine(trainStation.TrainDeparture(direction));
            Console.ReadLine();
        }
    }
}