namespace Task2;

public class Dog : Animal
{
    public Dog()
    {
        
    }
    public Dog(string name)
    {
        base.SetName(name);
        // base.Name = name;
    }
    public override void Eat()
    {
        System.Console.WriteLine($"{base.GetName()} eating");
        // System.Console.WriteLine($"{base.Name} eating");
    }
}
