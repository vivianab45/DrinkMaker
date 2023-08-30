//always carbonated
//can be diet or not

class Soda: Drink
{
    //field uniqe to child;
    public bool IsDiet;

    //constructor
    public Soda (string n, string col, double t, int cal, bool id) : base( n, col, t, true, cal) 
    {
        IsDiet=id;
    }
    //method to override parent ShowDrink()
    public override void ShowDrink()
    {
        base.ShowDrink();
        //add in the extra pieces
        Console.WriteLine($"Is Diet: {IsDiet}");
    }
}