namespace RealPattern.Observer;

public class TeamsService : INotifyObserver
{
    public INotifySubject Subject { get; }

    public TeamsService(INotifySubject subject)
    {
        Subject = subject;
    }
    public void Subscribe() => Subject.Notify += Notify;

    private void Notify(object? sender, NotificationEventArgs e)
    {
        Console.WriteLine($"Teams: {e.Message}");
    }
}