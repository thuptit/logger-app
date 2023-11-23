namespace RealPattern.Middleware;

public interface IMiddleware
{
    void Invoke(object context, RequestDelegate next);
}
public delegate void RequestDelegate(object context);