namespace RealPattern.Composite;

public class Menu : MenuComponent
{
    private Lazy<List<MenuComponent>> _lazyMenu;
    public Menu(string name, string description)
    {
        Name = name;
        Description = description;
        _lazyMenu = new Lazy<List<MenuComponent>>(() => new List<MenuComponent>());
    }

    public override string Name { get; }
    public override string Description { get; }
    public override void Add(MenuComponent component)
    {
        _lazyMenu.Value.Add(component);
    }

    public override void Remove(MenuComponent component)
    {
        _lazyMenu.Value.Remove(component);
    }

    public override MenuComponent Get(int index)
    {
        return _lazyMenu.Value[index];
    }

    public override void Print()
    {
        Console.WriteLine(Name);
        Console.WriteLine("--------------");
        foreach (var menuComponent in _lazyMenu.Value)
        {
            menuComponent.Print();
        }
        Console.WriteLine();
    }
}