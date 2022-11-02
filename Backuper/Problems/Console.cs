namespace Backuper.Problems;

internal static class Console
{
    internal static class NotConfigured
    {
        internal static string ZipDir()
        {
            StartMessage();
            System.Console.WriteLine("Please enter directory to backups Zip files");
            return System.Console.ReadLine();
        }

        private static void StartMessage()
        {
            System.Console.WriteLine("Program not configured");
        }
    }
}