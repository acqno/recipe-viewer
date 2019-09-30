using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyRecipe.Models;

namespace MyRecipe.Controllers
{
  public class HomeController : Controller
  {
    // Action method that calls the index (homepage) view 
    public ViewResult Index()
    {
      return View();
    }

    // Action method that calls the AddRecipeForm view 
    [HttpGet]
    public ViewResult AddRecipeForm()
    {
      return View();
    }

    // Action method that uses HttpPost method in order to display the 'submitted' view once a recipe has been submitted
    [HttpPost]
    public ViewResult AddRecipeForm(Recipe recipe)
    {
            if (ModelState.IsValid)
            {
                RecipeList.AddRecipe(recipe);
                return View("Submitted");
            }
            else
            {
                return View();
            }
    }

    // Action method that calls the RecipesList view to display all recipes 
    public ViewResult RecipesList()
    {
      return View(RecipeList.Recipes);
    }

    public ViewResult Review()
    {
        return View(RecipeList.Recipes);
    }

    public ViewResult RecipeInfo()
        {
            return View();
        }
  }
}
