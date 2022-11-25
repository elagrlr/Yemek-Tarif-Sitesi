using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme_Odevi.Models
{
    [Table("Recipes")]
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public int C_Id { get; set; }
        public int UserId { get; set; }
        public string PrepTime { get; set; }
        public string CookTime { get; set; }
        public string Person { get; set; }
        public string Difficulty { get; set; }
        public int Calories { get; set; }
        public string RecipeImg { get; set; }
        public string Ingredients { get; set; }
        public string RecipeDetails { get; set; }
    }
}