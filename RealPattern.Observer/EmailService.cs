namespace RealPattern.Observer;

public class EmailService : INotifyObserver
{
    public INotifySubject Subject { get; }

    public EmailService(INotifySubject subject)
    {
        Subject = subject;
    }
    public void Subscribe() => Subject.Notify += Notify;
    public void OnDestroy() => Subject.Notify -= Notify;
    private void Notify(object? sender, NotificationEventArgs e)
    {
        Console.WriteLine($"Email: {e.Message}");
    }
}