namespace Aufgabe_1
{
    internal interface IAutoFactory
    {
        ICarShowroom CreateCarShowroom();
        ICar CreateClassOfCar();
    }
}