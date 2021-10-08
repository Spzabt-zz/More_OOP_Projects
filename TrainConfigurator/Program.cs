using System;

namespace TrainConfigurator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool isOpen = true;
            Dispatcher trainStation = new Dispatcher();
            while (isOpen)
            {
                trainStation.CreateTrain();
                trainStation.TrainDeparture();
                Console.SetCursorPosition(50, 21);
                Console.WriteLine("Нажмите Enter для создания нового маршрута.");
                Console.SetCursorPosition(50, 22);
                Console.WriteLine("Нажмите 1 для выхода из программы");
                Console.SetCursorPosition(0, 0);
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.D1)
                    isOpen = false;
                Console.Clear();
            }
        }
    }
}