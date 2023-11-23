namespace RealPattern.Middleware;

public class CustomMiddleware : IMiddleware
{
    public void Invoke(object context, RequestDelegate next)
    {
        //TODO: handle at here
        Console.WriteLine("Start Custom Middleware");
        next(context);
        Console.WriteLine("End Custom Middleware");
    }
}