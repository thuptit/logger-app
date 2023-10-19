namespace RealPattern.Logger;

public class FileLogStrategy : LogStrategy
{
    private FileContentWriter _writer = new ("log.txt");
    protected override bool DoLog(string logMessage)
    {
        return _writer.WriteToMedia(logMessage);
    }
}