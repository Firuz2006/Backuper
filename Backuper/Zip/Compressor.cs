using System.IO.Compression;

namespace Backuper.Zip;

internal class Compressor
{
    internal void Compress()
    {
        ZipFile.CreateFromDirectory(Properties.FilesDirectory,
            Properties.ZipDirectory + DateTime.Now.ToString("u") + ".zip");
    }
}






