namespace Aufgabe_1
{
    class CabrioletFactory : IAutoFactory

    {
        public ICarShowroom CreateCarShowroom()
        {
            return new Dream();
        }

        public ICar CreateClassOfCar()
        {
            return new Cabriolet();
        }
    }
}