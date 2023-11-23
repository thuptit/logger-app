namespace RealPattern.Composite;

public abstract class MenuComponent
{
    public virtual void Add(MenuComponent component)
    {
        
    }

    public virtual void Remove(MenuComponent component)
    {
        
    }

    public virtual MenuComponent Get(int index)
    {
        throw new NotImplementedException();
    }
    public virtual string Name { get; }
    public virtual string Description { get; }
    public virtual bool Vegetarian { get; }
    public virtual decimal Price { get; }
    
    public virtual void Print(){}
}