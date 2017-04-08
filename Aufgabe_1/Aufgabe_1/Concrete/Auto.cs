namespace Aufgabe_1
{
    class Auto
    {
        //aвтомобиль никак не зависит от автосалона
        private ICarShowroom carshowroom;
        private ICar classofcar;

        public Auto(IAutoFactory factory)
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