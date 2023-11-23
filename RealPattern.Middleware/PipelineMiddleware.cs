namespace RealPattern.Middleware;

public class PipelineMiddleware
{
    private object _context;
    private List<IMiddleware> _enumerableImplementation = new List<IMiddleware>();
    public void AddMiddleware(IMiddleware middleware) => _enumerableImplementation.Add(middleware);

    public void Run()
    {
        Executed(0,_context);
    }

    private void Executed(int index, object context)
    {
        if (index < _enumerableImplementation.Count)
        {
            _enumerableImplementation[index].Invoke(context, (o) => {Executed(index + 1, context);});
        }
    }
}