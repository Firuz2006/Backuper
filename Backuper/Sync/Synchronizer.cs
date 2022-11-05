namespace Backuper.Sync;

internal class Synchronizer
{
    internal Synchronizer()
    {
        Synchronize();
    }

    internal void ReSync()
    {
        Synchronize();
    }
    
    private void Synchronize()
    {
        Properties.Platform = EnvironmentWork.GetOs();
        
        Properties.PropertiesDir = EnvironmentWork.GetPropDir();
        if (!Directory.Exists(Properties.PropertiesDir))
            Directory.CreateDirectory(Properties.PropertiesDir);

        Properties.ZipDirectory = EnvironmentWork.GetZipDir();
        
        if (!Directory.Exists(Properties.ZipDirectory))
            Directory.CreateDirectory(Properties.ZipDirectory);

        Properties.FilesDirectory = Environment.CurrentDirectory;
        // Properties.IgnoredDirectories = EnvironmentWork.GetIgnoredDir();

        Properties.LogPath = Properties.PropertiesDir + "MainLog.log";
        if (!File.Exists(Properties.LogPath))
            File.Create(Properties.LogPath);
    }
}