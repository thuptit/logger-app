namespace RealPattern.ChainOfResponsibility;

public class ValidatorOrderHandler : OrderHandler
{
    public override void Process(Order order)
    {
        if (order.IsValue)
        {
            if(nextHandler != null) 
                nextHandler.Process(order);
        }
    }
}