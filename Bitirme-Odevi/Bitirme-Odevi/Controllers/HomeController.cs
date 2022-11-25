using Bitirme_Odevi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bitirme_Odevi.Models;

namespace Bitirme_Odevi.Controllers
{
    public class HomeController : Controller
    { 
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JAF8PNH/SQLEXPRESS;Initial Catalog=YemekTarifleri;Integrated Security=True");
        public YemekTarifleriEntities db = new YemekTarifleriEntities();
        Class1 model = new Class1();
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Anasayfa()
        {
            //List<Reicpes> Tarifler = db.Reicpes.ToList();
            model.Blogs = db.Blog.ToList();
            model.BlogKategori = db.BlogCategories.ToList();
            model.Yorumlar = db.Comments.ToList();
            model.TarifBul = db.FindRecipe.ToList();
            model.Malzemeler = db.Ingredients.ToList();
            model.Menuler = db.Menus.ToList();
            model.MenuKategori = db.MenuCategories.ToList();
            model.Tarifler = db.Reicpes.ToList();
            model.TarifKategori = db.RecipeCategories.ToList();
            model.Kullanicilar = db.Users.ToList();

            return View(model);
        }
        public ActionResult Kategoriler()
        {
            return View(model);
        }
        public ActionResult KategoriDetay()
        {
            return View(model);
        }
        public ActionResult AltKategoriDetay()
        {
            return View(model);
        }
        public ActionResult TarifDetay()
        {
            return View(model);
        }
        public ActionResult TarifPaylas()
        {
            return View(model);
        }

        public ActionResult Menuler()
        {
            return View(model);
        }
        public ActionResult MenuDetay()
        {
            return View(model);
        }
        public ActionResult AltMenuDetay()
        {
            return View(model);
        }

        public ActionResult NePisirilir()
        {
            return View(model);
        }
        public ActionResult Blog()
        {
            return View(model);
        }
        public ActionResult BlogIcerik()
        {
            return View(model);
        }
        public ActionResult BlogDetay()
        {
            return View(model);
        }

        public ActionResult GirisYap()
        {
            //List<Users> Kullanicilar = db.Users.ToList();
            return View(model);
        }
        
        public ActionResult Kaydol()
        {
            return View(model);
        }

        public ActionResult KullaniciProfil()
        {
            return View(model);
        }
     
        public ActionResult Admin()
        {
            model.Blogs = db.Blog.ToList();
            model.BlogKategori = db.BlogCategories.ToList();
            model.Yorumlar = db.Comments.ToList();
            model.TarifBul = db.FindRecipe.ToList();
            model.Malzemeler = db.Ingredients.ToList();
            model.Menuler = db.Menus.ToList();
            model.MenuKategori = db.MenuCategories.ToList();
            model.Tarifler = db.Reicpes.ToList();
            model.TarifKategori = db.RecipeCategories.ToList();
            model.Kullanicilar = db.Users.ToList();
            return View(model);
            
        }

        //private ActionResult Admin(string v1, string v2, string v3)
        //{
        //    List<Reicpes> Tarifler = db.Reicpes.ToList();
        //    List<Users> Kullanicilar = db.Users.ToList();
        //    List<RecipeCategories> TarifKategori = db.RecipeCategories.ToList();
        //    SqlCommand komut2 = new SqlCommand("select* from Reicpes R left join Users U on U.Id = R.UserId ", baglanti);
        //    SqlCommand komut3 = new SqlCommand("select* from Reicpes R left join RecipeCategories RC on RC.Id = R.C_Id ", baglanti);

        //    ViewBag.v1 = Kullanicilar;
        //    ViewBag.v2 = Tarifler;
        //    ViewBag.v3 = TarifKategori;

        //    return View(v1, v2, v3);
        //}

        public ActionResult Tarifler( )
        {
            //List<Reicpes> Tarifler = db.Reicpes.ToList();
            //List<Users> Kullanicilar = db.Users.ToList();
            //List<RecipeCategories> TarifKategori = db.RecipeCategories.ToList();
            //SqlCommand komut2 = new SqlCommand("select* from Reicpes R left join Users U on U.Id = R.UserId ", baglanti);
            //SqlCommand komut3 = new SqlCommand("select* from Reicpes R left join RecipeCategories RC on RC.Id = R.C_Id ", baglanti);
             return View(model);
        }
        public ActionResult Menu() 
        { 
            return View(model);
        }
        public ActionResult Kullanicilar() {

            //List<Users> Kullanicilar = db.Users.ToList();
            return View(model);
        }
        public ActionResult Kategori()
        {
            return View(model);
        }
        public ActionResult Yorumlar()
        {
            return View(model);
        }
       
        public ActionResult AdminBlog()
        {
            //List<Blog> Blog = db.Blog.ToList();
            //List<BlogCategories> BlogKategori = db.BlogCategories.ToList();

            //SqlCommand komut = new SqlCommand("select* from Blog B left join BlogCategories BC on BC.Id = B.BlogCategory ", baglanti);
           

            return View(model);
        }
        public ActionResult About()
        {
            
            return View( );
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}