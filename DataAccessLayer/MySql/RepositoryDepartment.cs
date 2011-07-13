using System;
using BussinessLayer.IRepository;
using Model = BussinessLayer.Model;

namespace DataAccessLayer
{
    public class RepositoryDepartment : Base<Model.Department>, IRepositoryDepartment
    {
        #region IRepositoryDepartment Members

        public void IsDepartmentExist()
        {
            throw new NotImplementedException();
        }

        #endregion IRepositoryDepartment Members
    }
}