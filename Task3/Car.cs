namespace Task3;

public class Car : IVehicle
{
    int _amount = 0;
    public Car(int amount)
    {
        _amount = amount;
    }
    public void Drive()
    {
        if (_amount > 0)
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
            _amount += amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}
