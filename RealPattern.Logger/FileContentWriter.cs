using System.Text;

namespace RealPattern.Logger;

public class FileContentWriter : BaseContentWriter
{
    private string _fileName;

    public FileContentWriter(string fileName)
    {
        _fileName = fileName;
    }
    public override bool WriteToMedia(string logContent)
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), _fileName);
        CreateIfNotExist(filePath);
        using (var fileSource = File.Open(filePath, FileMode.Append))
        {
            logContent += "\r\n";
            byte[] buffer = Encoding.UTF8.GetBytes(logContent);
            fileSource.Write(buffer,0,buffer.Length);
        }
        return true;
    }

    void CreateIfNotExist(string filePath)
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
        }
    }
}