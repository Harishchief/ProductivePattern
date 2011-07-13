using System.Data.Objects;

namespace DataAccessLayer
{
    public class RepositoryPatternContext : ObjectContext
    {
        //ObjectSet<BLLModel.User> _user = null;

        public RepositoryPatternContext()
            : base("name=LinkSmartzEntities", "LinkSmartzEntities")
        {
            //  _user = CreateObjectSet<BLLModel.User>();
        }

        //public ObjectSet<BLLModel.User> User
        //{
        //    get
        //    {
        //        return _user;
        //    }
        //}

        //// private RepositoryPatternContext context = null;

        //#region Save

        //public void Save(BussinessLayer.User model)
        //{
        //    //// ObjectSet<User> user = new ObjectSet<User>();
        //    //context = new RepositoryPatternContext();

        //    //context.CreateObjectSet<BussinessLayer.User>().AddObject(model);

        //    ////   context.User.AddObject(model);
        //    //context.SaveChanges();
        //}

        //#endregion Save
    }
}