namespace RealPattern.Observer;

public class NotifySubject : INotifySubject
{
    public event EventHandler<NotificationEventArgs>? Notify;

    public void NotifyAll() => Notify?.Invoke(this, new NotificationEventArgs("Update User Successfully"));
}