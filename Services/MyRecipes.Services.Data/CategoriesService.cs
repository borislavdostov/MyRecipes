using MyRecipes.Data.Common.Repositories;
using MyRecipes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyRecipes.Services.Data
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return categoriesRepository.AllAsNoTracking().Select(c => new
            {
                c.Id,
                c.Name,
            }).ToList().Select(c => new KeyValuePair<string, string>(c.Id.ToString(), c.Name));
        }
    }
}
