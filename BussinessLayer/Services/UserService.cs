using System.Collections.Generic;
using System.Linq;
using BussinessLayer.IRepository;

namespace BussinessLayer.Services
{
    public class UserService
    {
        private static IRepositoryUser Repository
        {
            get
            {
                return StructureMap.ObjectFactory.GetInstance<IRepositoryUser>();
            }
        }

        public static void Save(Model.User model)
        {
            Repository.Save(model);
        }

        public static void Remove(int id)
        {
            Repository.Remove(Repository.Find(x => x.UserId == id).FirstOrDefault());
        }

        public static Model.User GetById(int id)
        {
            return Repository.Find(x => x.UserId == id).FirstOrDefault();
        }

        public static List<Model.User> FindAll()
        {
            return Repository.FindAll();
        }
    }
}