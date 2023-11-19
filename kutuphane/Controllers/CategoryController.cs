using BusinnesLayer.Concrete;
using DataAccessLayer.EfFramework;
using Microsoft.AspNetCore.Mvc;

namespace kutuphane.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var getir = cm.TGetAll();
            return View();
        }
    }
}
