namespace RealPattern.Iterator;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

public interface IAggregate<T>
{
    IIterator<T> CreateInterator();
}

public class Playlist : IAggregate<Song>
{
    private List<Song> _songs = new();

    public IIterator<Song> CreateInterator()
    {
        return new PlaylistIterator(this);
    }

    public void AddSong(Song song) => _songs.Add(song);
    public int Count => _songs.Count;
    public Song this[int index] => _songs[index];
}

public class PlaylistIterator : IIterator<Song>
{
    private readonly Playlist _playlist;
    private int _index = 0;

    public PlaylistIterator(Playlist playlist)
    {
        _playlist = playlist;
    }
    public bool HasNext()
    {
        return _index < _playlist.Count;
    }

    public Song Next()
    {
        return _playlist[_index++];
    }
}

public class Song
{
    public Song(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}