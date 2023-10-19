namespace RealPattern.Logger;

public class ConsoleLogStrategy : LogStrategy
{
    private ConsoleContentWriter _writer = new();
    protected override bool DoLog(string logMessage)
    {
        return _writer.WriteToMedia(logMessage);
    }
}