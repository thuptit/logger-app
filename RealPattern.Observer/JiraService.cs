namespace RealPattern.Observer;

public class JiraService : INotifyObserver
{
    public INotifySubject Subject { get; }

    public JiraService(INotifySubject subject)
    {
        Subject = subject;
    }

    public void Subscribe() => Subject.Notify += Notify;

    private void Notify(object? sender, NotificationEventArgs e)
    {
        Console.WriteLine($"Jira: {e.Message}");
    }
}