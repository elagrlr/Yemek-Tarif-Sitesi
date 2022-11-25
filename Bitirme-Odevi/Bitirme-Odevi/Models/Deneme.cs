using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Bitirme_Odevi.Models
{
    public class Deneme
    {
        public List<Blog> Blogs { get; set; }
        public List<BlogCategories> BlogKategori { get; set; }
        public List<Comments> Yorumlar {get;set;}
        public List<FindRecipe> TarifBul { get; set; }
        public List<Ingredient> Malzemeler { get; set; }
        public List<MenuCategories> MenuKategori { get; set; }
        public List<Menus> Menuler { get; set; }
        public List<RecipeCategories> TarifKategori { get; set; }
        public List<Reicpes> Tarifler { get; set; } 
        public List<Users> Kullanicilar { get; set; }
        
        
       
        
    }
}
 