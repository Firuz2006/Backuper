namespace Backuper;

internal static class Properties
{
    internal static string? PropertiesDir { get; set; }
    internal static Os Platform { get; set; }
    internal static string? ZipDirectory { get; set; }
    internal static string? FilesDirectory { get; set; }
    internal static string? IgnoredDirectories { get; set; }
    internal static string LogPath { get; set; }
}

internal enum Os
{
    Linux,
    Windows,
    Mac
}