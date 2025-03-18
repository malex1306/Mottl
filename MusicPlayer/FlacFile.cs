namespace MusicPlayer;

public class FlacFile : FormatAudioFile
{
    public override string FileType => "Flac";
    public FlacFile(string fileName) : base(fileName) { }

    public override void Play()
    {
        Console.WriteLine($"Playing lac File: {FileName}");
    }
}