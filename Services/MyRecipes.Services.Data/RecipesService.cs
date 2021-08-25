using MyRecipes.Data.Common.Repositories;
using MyRecipes.Data.Models;
using MyRecipes.Web.ViewModels.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipes.Services.Data
{
    public class RecipesService : IRecipesService
    {
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;

        public RecipesService(
            IDeletableEntityRepository<Recipe> recipesRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRepository
            )
        {
            this.recipesRepository = recipesRepository;
            this.ingredientsRepository = ingredientsRepository;
        }

        public async Task CreateAsync(CreateRecipeInputModel input)
        {
            var recipe = new Recipe
            {
                CategoryId = input.CategoryId,
                Name = input.Name,
                Instructions = input.Instructions,
                PreparationTime = TimeSpan.FromMinutes(input.PreparationTime),
                CookingTime = TimeSpan.FromMinutes(input.CookingTime),
                PortionsCount = input.PortionsCount,
            };

            foreach (var inputIngredient in input.Ingredients)
            {
                var ingredient = ingredientsRepository.All().FirstOrDefault(i => i.Name == inputIngredient.Name);
                if (ingredient == null)
                {
                    ingredient = new Ingredient
                    {
                        Name = inputIngredient.Name,
                    };
                }

                recipe.Ingredients.Add(new RecipeIngredient
                {
                    Ingredient = ingredient,
                    Quantity = inputIngredient.Quantity,
                });

                await recipesRepository.AddAsync(recipe);
                await recipesRepository.SaveChangesAsync();
            }
        }
    }
}
