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
            Recipe recipe = new Recipe();
            recipe.Name = "pizza";

            return View(recipe);
        }

        public ViewResult AddRecipeForm()
        {
            return View();
        }
    }
}
