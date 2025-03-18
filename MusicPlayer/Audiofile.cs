namespace MusicPlayer;

public abstract class Audiofile
{
    public string FileName { get; }
    public abstract string FileType { get; }

    protected Audiofile(string fileName)
    {
        FileName = fileName;
    }
    
    public abstract void Play();
}