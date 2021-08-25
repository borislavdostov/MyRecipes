using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipes.Services.Data
{
    public interface ICategoriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();
    }
}
