using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLLModel = BussinessLayer.Model;
using BLLService = BussinessLayer.Services;

namespace TestCase
{
    [TestClass]
    public class Department
    {
        public Department()
        {
            BootScrapper.ConfigureStructureMap();
        }

        [TestMethod]
        public void Save()
        {
            List<BLLModel.Department> departments = new List<BLLModel.Department>();
            departments.Add(new BLLModel.Department
            {
                Name = "ICU"
            });

            departments.Add(new BLLModel.Department
            {
                Name = "Emergency Block"
            });

            departments.Add(new BLLModel.Department
            {
                Name = "Blood Bank"
            });

            foreach (BLLModel.Department oDepartment in departments)
            {
                BLLService.DepartmentService.Save(oDepartment);
            }

            System.Console.Write("Record has been saved");
        }

        [TestMethod]
        public void Remove()
        {
            var departments = BLLService.DepartmentService.FindAll();

            if (departments != null && departments.Count > 0)
            {
                BLLService.DepartmentService.Remove(departments.FirstOrDefault().DepartmentId);
                System.Console.Write("Record has been removed");
            }
        }

        [TestMethod]
        public void GetAll()
        {
            List<BLLModel.Department> departments = BLLService.DepartmentService.FindAll();
            if (departments != null)
                System.Console.Write(string.Format("{0} record has been fetched", departments.Count));
            else
                System.Console.Write("object is null");
        }

        [TestMethod]
        public void GetById()
        {
            BootScrapper.ConfigureStructureMap();

            var departments = BLLService.DepartmentService.FindAll();

            if (departments != null && departments.Count > 0)
            {
                BLLModel.Department user = BLLService.DepartmentService.GetById(departments.FirstOrDefault().DepartmentId);

                if (user != null)
                    System.Console.Write("object has been return successully");
                else
                    System.Console.Write("object is null");
            }
        }
    }
}