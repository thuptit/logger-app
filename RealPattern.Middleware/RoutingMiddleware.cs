namespace RealPattern.Middleware;

public class RoutingMiddleware : IMiddleware
{
    public void Invoke(object context, RequestDelegate next)
    {
        //TODO: handle at here
        Console.WriteLine("Start Routing Middleware");
        next(context);
        Console.WriteLine("End Routing Middleware");
    }
}