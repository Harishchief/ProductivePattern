using System.Web.Mvc;
using BLLModel = BussinessLayer.Model;
using BLLService = BussinessLayer.Services;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            Save();
            //Remove(3);
            //Save();
            //  var a = GetById();
            //var b = GetAll();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public void Save()
        {
            BLLService.DepartmentService.Save(new BLLModel.Department
            {
                Name = "ICU"
            });
        }
    }
}