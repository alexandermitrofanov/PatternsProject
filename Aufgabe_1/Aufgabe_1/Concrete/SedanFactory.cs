namespace Aufgabe_1
{
    class SedanFactory: IAutoFactory
    {
        public ICarShowroom CreateCarShowroom()
        {
            return new Podium();
        }

        public ICar CreateClassOfCar()
        {
            return new Sedan();
        }
    }
}