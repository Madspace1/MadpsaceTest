/*Create a Car class:

Properties: Make, Model, Year

Constructor that initializes these properties

Create a few Car objects and print their properties to the console. */

using _35_classes__car_;

Car car1 = new Car("BMW", "X5", 2011);
Car car2 = new Car("Fiat", "Punto 2", 2000);
Car car3 = new Car("Tesla", "Light", 2044);

Console.WriteLine($"{car1.GetCarInfo()}");
Console.WriteLine($"{car2.GetCarInfo()}");
Console.WriteLine($"{car3.GetCarInfo()}");