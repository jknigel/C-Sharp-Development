namespace RecipeManagerApp.Services;
//using RecipeManagerApp.Models;

public class RecipeService
{
    private List<Recipe> _recipes = new() {
        new Recipe { Id = 1, Name = "Sashimi Platter", Description = "A Japanese cuisine loved by people"},
        new Recipe { Id = 2, Name = "Wagyu Beef", Description = "Delicious beef exclusively from Japan"}
    };
    private int _nextId = 3;

    public List<Recipe> GetAllRecipes() => _recipes;

    // --- ADD THIS METHOD ---
    // It finds the first recipe that matches the given id, or returns null if none is found.
    public Recipe? GetRecipeById(int id)
    {
        return _recipes.FirstOrDefault(r => r.Id == id);
    }
    // -----------------------
    
    public void AddRecipe(Recipe recipe)
    {
        recipe.Id = _nextId++;
        _recipes.Add(recipe);
    }
}