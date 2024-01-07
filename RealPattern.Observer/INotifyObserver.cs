namespace RealPattern.Observer;

public interface INotifyObserver
{
    void Subscribe();
    INotifySubject Subject { get; }
}