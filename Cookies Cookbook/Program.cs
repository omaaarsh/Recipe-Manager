using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.Json;// Enum for File Format
class Program
{
    static void Main()
    {
        const FileFormat selectedFormat = FileFormat.Json; // Change to Txt if needed
        const string name="CookBook";
        var fileMetadata=new FileMetadata(name,selectedFormat);
        var ingredientsRegister=new IngredientsRegister();
        IStringRepository stringRepository = selectedFormat==FileFormat.Json?new StringJsonRepository():new StringTextualRepository();
        CookbookApp cookBook = new CookbookApp(new RecipesConsoleUserInteraction(ingredientsRegister)
        ,new RecipesRepository(stringRepository,ingredientsRegister));
        cookBook.Run(fileMetadata.ToPath());
    }
}