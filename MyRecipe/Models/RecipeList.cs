using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Models
{
    /// <summary>
    /// 
    /// This is the RecipeList repository
    /// It creates a list of recipes using the Recipe Model
    /// 
    /// </summary>
    public static class RecipeList
    {
        private static List<Recipe> recipes = new List<Recipe>();

        // This returns the current list of recipes 
        public static IEnumerable<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
        }

        // This method adds a new recipe to the list of recipes
        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
    }
}
