class CookbookApp
{
    private readonly IRecipesUserInteraction _userInteraction;
    private readonly IRecipesRepository _iRecipesRepository;

    public CookbookApp( IRecipesUserInteraction userInteraction, IRecipesRepository iRecipesRepository)
    {
        _userInteraction = userInteraction;
        _iRecipesRepository = iRecipesRepository;
    }
    public void Run(string filePath)
    {
        // Load stored recipes
        var storedRecipes = _iRecipesRepository.Read(filePath);
        _userInteraction.PrintExistingRecipes(storedRecipes);
        // Get new recipe
        _userInteraction.PromptToCreateRecipe();
        var ingredients = _userInteraction.GetUserSelectedIngredients();
        if (ingredients.Any())
        {
            var recipe = new Recipe(ingredients);
            storedRecipes.Add(recipe);
            _iRecipesRepository.Write(filePath,storedRecipes);
            _userInteraction.ShowMessage("Recipe saved!");
            _userInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _userInteraction.ShowMessage("No ingredients selected. Recipe will not be saved.");
        }
        _userInteraction.Exit();
    }
}