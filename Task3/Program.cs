using Task3;

Car car = new Car(0);
car.Drive();
System.Console.WriteLine(car.Refuel(50));
car.Drive();
System.Console.WriteLine(car.Refuel(20));
car.Drive();
System.Console.WriteLine(car.Amount);