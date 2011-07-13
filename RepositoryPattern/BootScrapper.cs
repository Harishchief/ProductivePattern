using BussinessLayer.IRepository;
using DataAccessLayer;

namespace RepositoryPattern
{
    public class BootScrapper
    {
        public static void ConfigureStructureMap()
        {
            StructureMap.ObjectFactory.Initialize(x =>
            {
                x.For<IRepositoryUser>().Use(new RepositoryUser());
                x.For<IRepositoryDepartment>().Use(new RepositoryDepartment());
            });
        }
    }
}