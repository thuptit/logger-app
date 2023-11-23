namespace RealPattern.ChainOfResponsibility;

public class ShippingOrderHandler : OrderHandler
{
    public override void Process(Order order)
    {
        order.Ship();
    }
}