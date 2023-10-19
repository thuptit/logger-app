namespace RealPattern.Logger;

public class LoggerFactory
{
    private static ObjectFactory of = new ObjectFactory("LogStrategy.xml");
    public static LogStrategy CreateLogger(string loggerType)
    {
        return (LogStrategy)of.Get("FILE");
    }
}