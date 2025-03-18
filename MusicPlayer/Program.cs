namespace MusicPlayer;

class Program
{
    static void Main(string[] args)
    {
        AudioPlayer player = new AudioPlayer();
        
        player.AddFile(new Mp3File("Everlong.mp3"));
        player.AddFile(new WavFile("People = shit.wav"));
        player.AddFile(new FlacFile("Even if its kill me.flac"));

        Console.WriteLine("Normal Playback:");
        player.PlayAll();
        
        
        Console.WriteLine("\nShuffled Playback:");
        player.PlayAll(true); 
        
    }
}