namespace Task3;

public interface IVehicle
{
    int Amount { get; set; }
    void Drive();
    bool Refuel(int amount);
}
