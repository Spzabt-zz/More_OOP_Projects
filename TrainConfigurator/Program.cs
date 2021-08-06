using System;

namespace TrainConfigurator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TrainStation trainStation = new TrainStation();
            while (true)
            {
                Console.WriteLine("Задайте маршрут");
                string direction = Console.ReadLine();
                trainStation.CreateTrain(direction);
                trainStation.TrainDeparture();
                Console.SetCursorPosition(50, 21);
                Console.WriteLine("Нажмите Enter для создания нового маршрута.");
                Console.SetCursorPosition(50, 22);
                Console.WriteLine("Нажмите 1 для выхода из программы");
                Console.SetCursorPosition(0, 0);
                ConsoleKeyInfo userInput = Console.ReadKey();
                if(userInput.Key == ConsoleKey.D1)
                    Environment.Exit(0);
                Console.Clear();
            }
        }
    }
}