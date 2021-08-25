using Microsoft.AspNetCore.Mvc;
using MyRecipes.Web.ViewModels.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipes.Web.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateRecipeInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //TODO: Create recipe using service method
            //TODO: Redirect to recipe info page
            return Redirect("/");
        }
    }
}
