using MyRecipes.Data.Common.Repositories;
using MyRecipes.Data.Models;
using MyRecipes.Services.Data.Models;
using MyRecipes.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRecipes.Services.Data
{
    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        private readonly IRepository<Image> imageRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;

        public GetCountsService(
            IDeletableEntityRepository<Category> categoriesRepository,
            IRepository<Image> imageRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRepository,
            IDeletableEntityRepository<Recipe> recipesRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.imageRepository = imageRepository;
            this.ingredientsRepository = ingredientsRepository;
            this.recipesRepository = recipesRepository;
        }

        public CountsDto GetCounts()
        {
            var data = new CountsDto
            {
                RecipesCount = recipesRepository.All().Count(),
                CategoriesCout = categoriesRepository.All().Count(),
                IngredientsCount = ingredientsRepository.All().Count(),
                ImagesCount = imageRepository.All().Count(),
            };

            return data;
        }
    }
}
