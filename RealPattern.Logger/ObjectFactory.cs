using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Linq;

namespace RealPattern.Logger;

public class ObjectFactory
{
    private Dictionary<string, string> entries = new();
    private Dictionary<string, object> objects = new();

    public ObjectFactory(string file)
    {
        entries = LoadData(file);
    }
    private Dictionary<string, string> LoadData(string str)
    {
        var pathFile = Path.Combine(Directory.GetCurrentDirectory(), str);
        return XDocument.Load(pathFile)
            .Descendants("entries")
            .Descendants("entry")
            .ToDictionary(x => x.Attribute("key").Value, x => x.Attribute("value").Value);
    }

    public object Get(string key, string mode = "singleton")
    {
        if (mode != "singleton" && mode != "prototype")
            return null;

        object temp = null;
        if (objects.TryGetValue(key, out temp))
        {
            return (mode == "singleton") ? temp : temp.DeepClone();
        }

        string classname = string.Empty;
        entries.TryGetValue(key, out classname);
        if (string.IsNullOrEmpty(classname))
            return null;
        var type = Type.GetType(classname);
        if (type == null)
            return null;
        return Activator.CreateInstance(type);
    }
}

internal static class LogExtensions
{
    public static T DeepClone<T>(this T obj)
    {
        using (var stream = new MemoryStream())
        {
            BinaryFormatter binaryFormatter = new();
            binaryFormatter.Serialize(stream,obj);
            stream.Position = 0;
            return (T)binaryFormatter.Deserialize(stream);
        }
    }
}

