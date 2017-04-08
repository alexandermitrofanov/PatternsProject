using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //я не знаю, что делать с A4
            var Audi_A4 = new Auto(new SedanFactory());
            Audi_A4.ShowRoom();
            Audi_A4.TestOfCar();

            var Audi_TT = new Auto(new CabrioletFactory());
            Audi_TT.ShowRoom();
            Console.ReadLine();
        }
    }


    //абстрактный класс - автосалон 

    // абстрактный класс "класс автомобиля"

    // класс Podium

    // класс Dream

    // седан 

    // Кабриолет 


    // Фабрика выбора машины класса седана из автосалона Podium 
    // Фабрика выбора машины класса кабриолет из автосалона Dream 
}       


        