using System;

namespace Aufgabe_1
{
    class Podium : ICarShowroom
    {
        public void View()
        {
            Console.WriteLine("Просматриваем автомобили в автосалоне Podium");
        }
    }
}