namespace RealPattern.Composite;

public class MenuItem : MenuComponent
{
    public MenuItem(string name, string description, bool isveg, decimal price)
    {
        Name = name;
        Description = description;
        Vegetarian = isveg;
        Price = price;
    }

    public override string Name { get; }
    public override string Description { get; }
    public override bool Vegetarian { get; }
    public override decimal Price { get; }

    public override void Print()
    {
        Console.WriteLine($"{Name}: {Price} {(Vegetarian ? "+" : "*")} \n {Description}");
    }
}