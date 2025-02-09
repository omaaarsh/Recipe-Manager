class RecipesRepository : IRecipesRepository
{
    private readonly IStringRepository _StringRepository;
    private readonly IIngredientsRegister _ingredientsRegister;
    private static readonly string separator=",";
    public RecipesRepository(IStringRepository StringRepository,IIngredientsRegister ingredientsRegister){
        _StringRepository=StringRepository;
        _ingredientsRegister= ingredientsRegister;
    }
    public List<Recipe> Read(string filePath)
    {
        var recipesFromFile=_StringRepository.Read(filePath);
        var recipesList= new List<Recipe>();
        foreach(var recipeFromFile in recipesFromFile ){
            var recipe= RecipeFromString(recipeFromFile);
            recipesList.Add(recipe);
        }
        return recipesList;
    }
    public Recipe RecipeFromString(string recipeFromFile)
    {
        var textualIDs= recipeFromFile.Split(separator);
        var ingredients =new List<Ingredient>();
        foreach (var textualID  in textualIDs)
        {
            var id = int.Parse(textualID);
            var ingredient=_ingredientsRegister.GetById(id);
            ingredients.Add(ingredient);
        }
        return new Recipe(ingredients);
    }

    public void Write(string filePath,List<Recipe> recipes)
    {
        var recipesAsString= new List<string>();
        foreach(var recipe in recipes){
            var recipeIDs= new List<int>();
            foreach (var ingredient in recipe.Ingredients)
            {
                recipeIDs.Add(ingredient.Id);
            }
            recipesAsString.Add(string.Join(separator,recipeIDs));
        }
        _StringRepository.Write(filePath,recipesAsString);
    }
}