abstract class StringRepository:IStringRepository{
    private static readonly string separator=Environment.NewLine;
    public List<string> Read(string filePath)
    {
        if (!File.Exists(filePath)) return new List<string>();
        var fileContent = File.ReadAllText(filePath);
        return TextToString(fileContent);
        
    }
    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath,StringToText(strings));
    }
    abstract protected List<string> TextToString(string fileContent);
    abstract protected  string StringToText(List<string> strings);
}