namespace RealPattern.Logger;

public class ConsoleContentWriter : BaseContentWriter
{
    public override bool WriteToMedia(string logContent)
    {
        Console.WriteLine(logContent);
        return true;
    }
}