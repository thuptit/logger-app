namespace RealPattern.ChainOfResponsibility;

public class DiscountOrderHandler : OrderHandler
{
    public override void Process(Order order)
    {
        if (nextHandler != null)
        {
            order.ApplyDiscount();
            nextHandler.Process(order);
        }
    }
}