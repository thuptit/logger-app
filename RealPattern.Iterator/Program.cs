using RealPattern.Iterator;

var playList = new Playlist();
playList.AddSong(new Song("Viet Nam oi"));
playList.AddSong(new Song("Fall in Love"));
playList.AddSong(new Song("Windy Hills"));

var iterator = playList.CreateInterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next().Name);
}