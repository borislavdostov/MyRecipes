﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipes.Services.Data.Models
{
    public class CountsDto
    {
        public int RecipesCount { get; set; }

        public int CategoriesCout { get; set; }

        public int IngredientsCount { get; set; }

        public int ImagesCount { get; set; }
    }
}
