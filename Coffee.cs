//roast value(dark, medium, light)
//type of beans used

class Coffee: Drink
{
    //field uniqe to child;
    public string Roast;
    public string Beans;
    //constructor- (all the field values): base(parent field values)
    public Coffee (string n, string col, double t, int cal, string rst, string bns) : base( n, col, t, false, cal) 
    {
        Roast=rst;
        Beans=bns;
    }

        public override void ShowDrink()
    {
        base.ShowDrink();
        //add in the extra pieces
        Console.WriteLine($"Roast: {Roast}");
        Console.WriteLine($"Beans: {Beans}");
    }
}