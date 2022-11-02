using Backuper.Sync;
using Backuper.Zip;

public class Program
{
    private static void Main(string[] args)
    {
        Synchronizer synchronizer = new Synchronizer();
        Compressor compressor = new Compressor();
        compressor.Compress();
    }
}