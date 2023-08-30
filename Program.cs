

//write override methods for each child class that properly displays each class's 
//unique fields and run the loop again. 

Soda Coke= new Soda ("Coca-Cola", "brown", 38, 140, false);

Coffee Cappuccino= new Coffee( "French Vanilla", "light brown", 120, 110, "light", "Kenyan beans");

Wine Merlot= new Wine ("Merlot", "red", 32, 120, "Bordeaux", 1992);

//Create a list of AllBeverages& add all instances-polymorphism
List <Drink> AllBeverages= new List<Drink>();
AllBeverages.Add(Coke);
AllBeverages.Add(Cappuccino);
AllBeverages.Add(Merlot);
//Loop through your list of AllBeverages and call the ShowDrink() method for each.

//we'll see the info from the parent class, but not the child unique values
foreach(Drink d in AllBeverages)
{
   d.ShowDrink();
}

Coffee MyDrink= new Soda("Coca-Cola", "brown", 38, 140, false);
//can't convert one child to another child; we can't make instances across
//child classes