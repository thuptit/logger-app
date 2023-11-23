namespace RealPattern.ChainOfResponsibility;

public abstract class OrderHandler
{
    protected OrderHandler nextHandler;
    public abstract void Process(Order order);
    public void NextProcess(OrderHandler handler) => nextHandler = handler;
}