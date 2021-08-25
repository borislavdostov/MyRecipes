using MyRecipes.Web.ViewModels.Recipes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipes.Services.Data
{
    public interface IRecipesService
    {
        Task CreateAsync(CreateRecipeInputModel input);
    }
}
