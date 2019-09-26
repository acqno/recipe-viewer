using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Models
{
    /// <summary>
    /// 
    /// This is the RecipeList Model
    /// It creates a list of recipes and returns it to the RecipeList View 
    /// 
    /// </summary>
    public static class RecipeList
    {
        private static List<Recipe> recipes = new List<Recipe>();

        public static IEnumerable<Recipe> Recipes
        {
            get
            {
                return Recipes;
            }
        }
    }
}
