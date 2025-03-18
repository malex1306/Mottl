namespace MusicPlayer;

public class Mp3File : FormatAudioFile
{
    public override string FileType => "MP3";

    public Mp3File(string fileName) : base(fileName) { }

    public override void Play()
    {
        Console.WriteLine($"Playing MP3 file: {FileName}");
    }
}