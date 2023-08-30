//region where it came from 
//year it was bottled

class Wine: Drink
{
    //field uniqe to child;
    public string Region;
    public int Year;
    //constructor- (all the field values): base(parent field values)
    public Wine (string n, string col, double t, int cal, string rgn, int yr) : base( n, col, t, false, cal) 
    {
        Region=rgn;
        Year=yr;
    }
    ////method to override
    public override void ShowDrink()
    {
        base.ShowDrink();
        //add in the extra pieces
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Year: {Year}");
    }
}