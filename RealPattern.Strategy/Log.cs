namespace RealPattern.Strategy;

public static class Log
{
    public static ILogStrategy Create(string strategy)
    {
        switch (strategy)
        {
            case  "console" :
                return new ConsoleLogStrategy();
            case "file":
                return new FileLogStrategy();
            default:
                throw new NotImplementedException();
        }
    }
}