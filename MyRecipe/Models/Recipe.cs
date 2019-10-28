using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Models
{
    /// <summary>
    /// This is the Recipe Model 
    /// This will be used to create Recipes that can be added to the RecipeList Model
    /// </summary>
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }

    }
}
