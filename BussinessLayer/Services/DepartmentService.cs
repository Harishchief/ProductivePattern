using System.Collections.Generic;
using System.Linq;
using BussinessLayer.IRepository;

namespace BussinessLayer.Services
{
    public class DepartmentService
    {
        private static IRepositoryDepartment Repository
        {
            get
            {
                return StructureMap.ObjectFactory.GetInstance<IRepositoryDepartment>();
            }
        }

        public static void Save(Model.Department model)
        {
            Repository.Save(model);
        }

        public static void Remove(int id)
        {
            Repository.Remove(Repository.Find(x => x.DepartmentId == id).FirstOrDefault());
        }

        public static Model.Department GetById(int id)
        {
            return Repository.Find(x => x.DepartmentId == id).FirstOrDefault();
        }

        public static List<Model.Department> FindAll()
        {
            return Repository.FindAll();
        }
    }
}