static class FileFormatExtension{
    public static string AsFileExtnsion(this FileFormat fileFormat )=>
    fileFormat == FileFormat.Json?"json":"txt"; 
}