using System.Web.Mvc;

namespace RepositoryPattern.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/

        public ActionResult Index()
        {
            //Remove(1);
            //Save();
            //var a = GetById(1);
            //var b = GetAll();

            return View();
        }

        //public void Remove(int id)
        //{
        //    BLLService.DepartmentService.Remove(id);
        //}

        //public List<BLLModel.Department> GetAll()
        //{
        //    return BLLService.DepartmentService.FindAll();
        //}

        //public BLLModel.Department GetById(int id)
        //{
        //    return BLLService.DepartmentService.GetById(id);
        //}
    }
}