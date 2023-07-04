namespace Task3;

public class Car : IVehicle
{
    public int Amount { get; set; }
    public Car(int amount)
    {
       Amount = amount;
    }
    public void Drive()
    {
        if (Amount > 0)
        {
            System.Console.WriteLine("Driving");
        }
        else
        {
            System.Console.WriteLine("Don't drive");
        }
    }
    public bool Refuel(int amount)
    {
        if (amount > 0)
        {
            Amount += amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}
