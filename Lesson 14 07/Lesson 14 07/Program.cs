
using System.Xml.Linq;
using Lesson_14_07;

House h1 = new House("Wroclaw, Niborska 12A/2", 65.8, 3);

Console.WriteLine(h1);


Console.WriteLine("123");

Pizza p1 = new Pizza(
    "Mozzarela", 
    38, 
    25);

Pizza p2 = new Pizza();

Console.WriteLine(p1.Name);

Animal a = new Animal("Kitty", 5, true);
a.IsAgressive = true;
a.DateOfPurchase = new DateTime(2019, 11, 23);

Console.WriteLine(a.Name);

class Pizza
{
    public string Name;
    public double Price;
    public double Diametr;
    public List<IngredientType> Ingredients;

    public Pizza()
        : this("Unknown", 0 , 0, new List<IngredientType>())
    {
    }

    public Pizza(string name, double price, double diameter)
        :this(name, price, diameter, new List<IngredientType>())
    {
    }

    public Pizza(string name, double price, double diameter, List<IngredientType> ingredients)
    {
  /*      if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name should be provided");
        }
        if(price < 1)
        {
            throw new ArgumentException("Price cannot be lower then 1");
        } */

        Name = name;
        Price = price;
        Diametr = diameter;
        Ingredients = ingredients;
    }
}

public enum IngredientType
{
    Mozzarella = 0,
    Cheez = 1,
    TomatoSouse = 2,
    Soueges = 3,
    Becon = 4,
}
