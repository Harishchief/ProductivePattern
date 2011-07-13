using BussinessLayer.IRepository;
using Model = BussinessLayer.Model;

namespace DataAccessLayer
{
    public class RepositoryUser : Base<Model.User>, IRepositoryUser
    {
        public override void Save(Model.User model)
        {
            //  MyProperty<BLLModels.ContactInfo>();
            context.CreateObjectSet<Model.ContactInfo>().AddObject(model.ContactInfo);
            context.SaveChanges();
            base.Save(model);
        }

        public override void Remove(Model.User model)
        {
            var contactInfo = model.ContactInfo;

            // delete from Child Table
            base.Remove(model);

            // delete from Parent Table
            context.DeleteObject(contactInfo);
            context.SaveChanges();
        }
    }
}