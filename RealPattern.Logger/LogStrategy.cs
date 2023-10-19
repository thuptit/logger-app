namespace RealPattern.Logger;

public abstract class LogStrategy
{
    protected abstract bool DoLog(string logMessage);

    public bool Log(string app, string key, string cause)
    {
        return DoLog(app + " " + key + ": " + cause);
    }
}