class StringTextualRepository:StringRepository{
    private static readonly string separator=Environment.NewLine;
    protected override List<string> TextToString(string fileContent){
        return fileContent.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
    protected override string StringToText(List<string> strings){
        return string.Join(separator,strings);
    }
}