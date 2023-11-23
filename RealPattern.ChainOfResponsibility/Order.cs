namespace RealPattern.ChainOfResponsibility;

public record Order()
{
    public bool IsValue { get; set; } = true;
    public void ApplyDiscount()
    {
        Console.WriteLine("Apply Discount ...");
    }

    public bool ProcessPayment()
    {
        Console.WriteLine("Payment successfully ...");
        return true;
    }

    public void Ship()
    {
        Console.WriteLine("Ship done ...");
    }
};