namespace MusicPlayer;

public class WavFile : FormatAudioFile
{
   public override string FileType => "WAV";

   public WavFile(string fileName) : base(fileName) { }

   public override void Play()
   {
      Console.WriteLine($"Playing WAV file: {FileName}");
   }
}