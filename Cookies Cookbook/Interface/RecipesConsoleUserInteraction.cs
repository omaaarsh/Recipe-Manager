public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    private readonly IIngredientsRegister _ingredientsRegister;

    public RecipesConsoleUserInteraction(IIngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }
    public void ShowMessage(string message) => Console.WriteLine(message);
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Any())
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);

            var counter = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"*****{counter}*****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                ++counter;
            }
        }
    }
    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients:");

        foreach (var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }
    public IEnumerable<Ingredient> GetUserSelectedIngredients()
    {
        var ingredients = new List<Ingredient>();

        while (true)
        {
            Console.WriteLine("Add an ingredient by its ID, or type anything else to finish:");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int id))
            {
                var selectedIngredient = _ingredientsRegister.GetById(id);
                if (selectedIngredient is not null)
                {
                    Console.WriteLine(selectedIngredient.Prepare);
                    ingredients.Add(selectedIngredient);
                }
            }
            else
            {
                break;
            }
        }

        return ingredients;
    }
}
