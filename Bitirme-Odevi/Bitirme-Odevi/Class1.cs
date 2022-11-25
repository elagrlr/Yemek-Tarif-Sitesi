using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bitirme_Odevi.Models;

namespace Bitirme_Odevi
{
    public class Class1
    {
        public List<Blog> Blogs { get; set; }
        public List<BlogCategories> BlogKategori { get; set; }
        public List<Comments> Yorumlar { get; set; }
        public List<FindRecipe> TarifBul { get; set; }
        public List<Ingredients> Malzemeler { get; set; }
        public List<MenuCategories> MenuKategori { get; set; }
        public List<Menus> Menuler { get; set; }
        public List<RecipeCategories> TarifKategori { get; set; }
        public List<Reicpes> Tarifler { get; set; }
        public List<Users> Kullanicilar { get; set; }

    }
}