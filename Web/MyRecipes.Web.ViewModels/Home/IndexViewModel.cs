﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipes.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public int RecipesCount { get; set; }

        public int CategoriesCout { get; set; }

        public int IngredientsCount { get; set; }

        public int ImagesCount { get; set; }
    }
}
