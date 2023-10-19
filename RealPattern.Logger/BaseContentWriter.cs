using System.Collections.Concurrent;

namespace RealPattern.Logger;

public abstract class BaseContentWriter : IContentWriter
{
    private ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
    private object _lock = new object();
    protected async Task<bool> Write(string message)
    {
        queue.Enqueue(message);
        if (queue.Count >= 10)
            return true;
        lock (_lock)
        {
            Task writeToMedia = Task.Run(() => Flush());
            Task.WaitAll(writeToMedia);
            return true;
        }
    }

    public abstract bool WriteToMedia(string logContent);

    async Task Flush()
    {
        string content =  string.Empty;
        int count = 0;
        while (queue.TryDequeue(out content) && count <= 10)
        {
            WriteToMedia(content);
        }
    }
    
}