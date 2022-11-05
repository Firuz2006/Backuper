using Backuper.Zip;

namespace Backuper.Problems;

internal static class Console
{
    internal static class NotConfigured
    {
        internal static string ZipDir()
        {
            StartMessage();
            System.Console.WriteLine("Please enter directory to backups Zip files");
            return System.Console.ReadLine()+"";
        }

        private static void StartMessage()
        {
            System.Console.WriteLine("Program not configured");
        }
    }


    internal static class Compress
    {
        internal static void StartCompress()
        {
            System.Console.Write("Compress was started.");
            Thread thread = new Thread(Dots);
            Compressor.Start += path =>
            {
                finish = false;
                Compress.path = path;
            };
            thread.Start();
            
        }

        private static bool finish;
        private static string path;
        private static void Dots()
        {
            finish = true;
            while (finish)
            {
                System.Console.Write('.');
                Thread.Sleep(300);
            }

            System.Console.WriteLine($"\nCompressing finished and saved at \"{path}\"");
        }
    }
}