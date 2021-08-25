using MyRecipes.Services.Data.Models;
using MyRecipes.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipes.Services.Data
{
    public interface IGetCountsService
    {
        CountsDto GetCounts();
    }
}
