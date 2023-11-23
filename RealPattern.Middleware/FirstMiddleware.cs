namespace RealPattern.Middleware;

public class FirstMiddleware : IMiddleware
{
    public void Invoke(object context, RequestDelegate next)
    {
        Console.WriteLine("Start Pipeline");
        next(context);
        Console.WriteLine("End Pipeline");
    }

}