namespace BussinessLayer.IRepository
{
    public interface IRepositoryDepartment : IBase<Model.Department>
    {
        void IsDepartmentExist();
    }
}