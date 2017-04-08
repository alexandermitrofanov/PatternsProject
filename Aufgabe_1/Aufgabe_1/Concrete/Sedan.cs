using System;

namespace Aufgabe_1
{
    class Sedan : ICar
    {
        public void Select()
        {
            Console.WriteLine("Выбираем автомобиль с типом кузова седан");
        }
        public void Start()
        {
            Console.WriteLine("Запускаем двигатель");
        }
        public void Fuel()
        {
            Console.WriteLine("Заправляем бак");
        }
        public void LightsOn()
        {
            Console.WriteLine("Включаем фары");
        }
        public void CheckInformation()
        {
            Console.WriteLine("Информация проверенна");
        }
        public void Run()
        {
            Console.WriteLine("Начинаем движение");
        }

    }
}