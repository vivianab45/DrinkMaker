//parent class
public class Drink
{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;
    
    // We need a basic constructor that takes all these features in
    public Drink(string name, string color, double temp, bool isCarb, int calories)
    {
    	Name = name;
    	Color = color;
    	Temperature = temp;
    	IsCarbonated = isCarb;
    	Calories = calories;
    }
    //method-ShowDrink()-displays info about the drink

//"virtual lets us override
    public virtual void ShowDrink()
    {   Console.WriteLine("*****************");
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Color:{Color}");
        Console.WriteLine($"Temperature:{Temperature}");
        Console.WriteLine($"IsCarbonated:{IsCarbonated}");
        Console.WriteLine($"Calories:{Calories}");

    }
}