using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bitirme_Odevi.Models
{
    [Table("RecipeCategories")]
    public class RecipeCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImg { get; set; }
    }
}