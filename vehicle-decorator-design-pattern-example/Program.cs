using vehicle_decorator_design_pattern_example;

internal class Program
{
    private static void Main(string[] args)
    {
        Vehicle car = new Car("Dacia", "Logan", 100, 180);

        car.Display();

        Console.WriteLine("Made car leasable\n=-=-=-=-=-=-=-=-=\n");

        Leasable leasableCar = new Leasable(car);
        leasableCar.LeaseVehicle("Andrei");
        leasableCar.Display();
    }
}