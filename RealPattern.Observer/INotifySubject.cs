namespace RealPattern.Observer;

public interface INotifySubject
{
    event EventHandler<NotificationEventArgs> Notify; 
    void NotifyAll();
}

public class NotificationEventArgs : EventArgs
{
    public NotificationEventArgs(string message) => Message = message;
    public string Message { get; set; }
}