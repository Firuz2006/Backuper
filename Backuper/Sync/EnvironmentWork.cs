using Console = Backuper.Problems.Console;

namespace Backuper.Sync;

internal static class EnvironmentWork
{
    internal static string GetPropDir()
    {
        var user = GetUser();
        switch (Properties.Platform)
        {
            case Os.Linux:
                return user == "root" ? "/root/.backuper/" : $"/home/{user}/.backuper/";
            
            case Os.Windows:
                return $"C:\\{user}\\appData\\Roaming\\backuper\\";
        }

        return "";
    }

    internal static Os GetOs()
    {
        var platformId = Environment.OSVersion.Platform;
        switch (platformId)
        {
            case PlatformID.Unix:
                return Os.Linux;
            
            case PlatformID.Win32S:
                return Os.Windows;
            case PlatformID.Win32Windows:
                return Os.Windows;
            case PlatformID.Win32NT:
                return Os.Windows;
            case PlatformID.WinCE:
                return Os.Windows;
            
            case PlatformID.MacOSX:
                return Os.Mac;
        }

        return Os.Linux;
    }

    internal static string GetUser()
    {
        return Environment.UserName;
    }

    internal static string GetZipDir()
    {
        string zipDirProp = Properties.PropertiesDir + "ZipDir.backuperConfig";
        if (!File.Exists(zipDirProp))
        {
            File.Create(zipDirProp);
        }
        
        string zipDir=File.ReadAllText(zipDirProp);
        if (!Directory.Exists(zipDir))
        {
            File.WriteAllText(zipDirProp,Console.NotConfigured.ZipDir());
            return GetZipDir();
        }

        return zipDir;
    }

    public static string GetIgnoredDir()
    {
        return File.ReadAllText(Properties.PropertiesDir + "IgnoredDirs.backuperConfig");
    }
}