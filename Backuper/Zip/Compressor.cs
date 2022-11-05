using System.IO.Compression;
using Console = Backuper.Problems.Console;

namespace Backuper.Zip;

internal class Compressor
{
    internal delegate void _action(string path);

    internal static event _action Start;
    internal void Compress()
    {
        Console.Compress.StartCompress();
        string path = Properties.ZipDirectory + DateTime.Now.ToString("u") + ".zip";
        ZipFile.CreateFromDirectory(Properties.FilesDirectory,path
            );
        Start.Invoke(path);
    }
}