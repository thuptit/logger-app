namespace RealPattern.ChainOfResponsibility;

public class PaymentOrderHandler : OrderHandler
{
    public override void Process(Order order)
    {
        if (nextHandler != null)
        {
            order.ProcessPayment();
            nextHandler.Process(order);
        }
    }
}