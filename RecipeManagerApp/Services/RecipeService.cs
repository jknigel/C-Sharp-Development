namespace YourProjectName.Services;

// We need this to know what a 'Recipe' is
using YourProjectName.Models; 

public class RecipeService
{
    // This is the MASTER LIST. It now lives here, not in a component.
    private List<Recipe> _recipes = new() {
        new Recipe { Id = 1, Name = "Sashimi Platter", Description = "A Japanese cuisine loved by people"},
        new Recipe { Id = 2, Name = "Wagyu Beef", Description = "Delicious beef exclusively from Japan"}
    };
    
    // A simple counter to ensure new recipes get a unique ID
    private int _nextId = 3;

    // A public method to get ALL recipes
    public List<Recipe> GetAllRecipes()
    {
        return _recipes;
    }

    // THIS IS THE METHOD YOU NEED
    // A public method to ADD a new recipe to the master list
    public void AddRecipe(Recipe newRecipe)
    {
        // Assign a new, unique ID before adding
        newRecipe.Id = _nextId++;
        _recipes.Add(newRecipe);
    }
}