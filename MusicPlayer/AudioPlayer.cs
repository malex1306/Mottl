namespace MusicPlayer;

public class AudioPlayer
{
    private Dictionary<int, Audiofile> files = new Dictionary<int, Audiofile>();
    private int nextId = 1;

    public void AddFile(Audiofile file)
    {
        files[nextId] = file;
        nextId++;
    }

    public void RemoveFile(int id)
    {
        files.Remove(id);
    }

    public void Play(int id)
    {
        if (files.TryGetValue(id, out var file))
        {
            file.Play();
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void PlayAll(bool shuffle = false)
    {
        var fileList = files.Values.ToList();
        
        if (shuffle)
        {
            Random rnd = new Random();
            fileList = fileList.OrderBy(x => rnd.Next()).ToList();
        }

        foreach (var file in fileList)
        {
            file.Play();
        }
    }

}