using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Audi_A4 = new Auto(new SedanFactory());
            Audi_A4.ShowRoom();
            Audi_A4.TestOfCar();

            Auto Audi_TT = new Auto(new CabrioletFactory());
            Audi_TT.ShowRoom();
            Audi_TT.TestOfCar();


            Console.ReadLine();
        }
    }


    //абстрактный класс - автосалон 
    abstract class CarShowroom
    {
        public abstract void View();
    }

    // абстрактный класс "класс автомобиля"
    abstract class ClassOfCar
    {
        public abstract void Select();
        public abstract void Start();
        public abstract void Fuel();
        public abstract void LightsOn();
        public abstract void CheckInformation();
        public abstract void Run();
    }

    // класс Podium
    class Podium : CarShowroom
    {
        public override void View()
        {
            Console.WriteLine("Просматриваем автомобили в автосалоне Podium");
        }
    }

    // класс Dream
    class Dream : CarShowroom
    {
        public override void View()
        {
            Console.WriteLine("Просматриваем автомобили в автосалоне Dream");
        }
    }

    // седан 
    class Sedan : ClassOfCar
    {
        public override void Select()
        {
            Console.WriteLine("Выбираем автомобиль с типом кузова седан");
        }
        public override void Start()
        {
            Console.WriteLine("Запускаем двигатель");
        }
        public override void Fuel()
        {
            Console.WriteLine("Заправляем бак");
        }
        public override void LightsOn()
        {
            Console.WriteLine("Включаем фары");
        }
        public override void CheckInformation()
        {
            Console.WriteLine("Информация проверенна");
        }
        public override void Run()
        {
            Console.WriteLine("Начинаем движение");
        }

    }

    // Кабриолет 
    class Cabriolet : ClassOfCar
    {
        public override void Select()
        {
            Console.WriteLine("Выбираем автомобиль с типом кузова кабриолет");
        }
        public override void Start()
        {
            Console.WriteLine("Запускаем двигатель");
        }
        public override void Fuel()
        {
            Console.WriteLine("Заправляем бак");
        }
        public override void LightsOn()
        {
            Console.WriteLine("Включаем фары");
        }
        public override void CheckInformation()
        {
            Console.WriteLine("Информация проверенна");
        }
        public override void Run()
        {
            Console.WriteLine("Начинаем движение");
        }
    }


    abstract class AutoFactory
    {
        public abstract CarShowroom CreateCarShowroom();
        public abstract ClassOfCar CreateClassOfCar();
    }

    // Фабрика выбора машины класса седана из автосалона Podium 
class SedanFactory: AutoFactory

    {
        public override CarShowroom CreateCarShowroom()
        {
            return new Podium();
        }

        public override ClassOfCar CreateClassOfCar()
        {
            return new Sedan();
        }
    }
    // Фабрика выбора машины класса кабриолет из автосалона Dream 
    class CabrioletFactory : AutoFactory

    {
        public override CarShowroom CreateCarShowroom()
        {
            return new Dream();
        }

        public override ClassOfCar CreateClassOfCar()
        {
            return new Cabriolet();
        }
    }

    class Auto
    {
        private CarShowroom carshowroom;
        private ClassOfCar classofcar;
        public Auto(AutoFactory factory)
        {
            carshowroom = factory.CreateCarShowroom();
            classofcar = factory.CreateClassOfCar();
        }
        public void ShowRoom()
        {
            carshowroom.View();
        }
        public void TestOfCar()
        {
            classofcar.Select();
            classofcar.Start();
            classofcar.Fuel();
            classofcar.LightsOn();
            classofcar.CheckInformation();
            classofcar.Run();
        }
    }

}       


        