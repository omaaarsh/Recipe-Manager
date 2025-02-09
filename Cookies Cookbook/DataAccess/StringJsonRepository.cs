using System.Text.Json;

class StringJsonRepository:StringRepository{
    protected override List<string> TextToString(string fileContent){
        return JsonSerializer.Deserialize<List<string>>(fileContent);
    }
    protected override string StringToText(List<string> strings){
        return JsonSerializer.Serialize(strings);
    }
}