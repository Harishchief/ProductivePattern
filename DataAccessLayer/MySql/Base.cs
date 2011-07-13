using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using BussinessLayer.IRepository;

namespace DataAccessLayer
{
    public abstract class Base<T> : IBase<T> where T : class
    {
        public RepositoryPatternContext context = new RepositoryPatternContext();

        public virtual void Save(T model)
        {
            if (model != null)
            {
                Entity.AddObject(model);
                context.SaveChanges();
            }
        }

        public virtual void Remove(T model)
        {
            if (model != null)
            {
                Entity.DeleteObject(model);
                context.SaveChanges();
            }
        }

        public List<T> Find(Expression<Func<T, bool>> predicate)
        {
            ArrayList oArrayListAssociations = FindAssociation();

            return (oArrayListAssociations.Count > 0) ? Entity.Include(oArrayListAssociations[oArrayListAssociations.Count - 1].ToString()).Where(predicate).ToList() : Entity.Where(predicate).ToList();
        }

        public List<T> FindAll()
        {
            ArrayList oArrayListAssociations = FindAssociation();
            if (oArrayListAssociations.Count > 0)
            {
                foreach (var oAssociation in oArrayListAssociations)
                {
                    return Entity.Include(oAssociation.ToString()).ToList();
                }
            }
            else
                return Entity.ToList();

            return null;
        }

        public ObjectSet<T> Entity
        {
            get
            {
                return context.CreateObjectSet<T>();
            }
        }

        #region Helper Method

        private ArrayList FindAssociation()
        {
            ArrayList oArrayListAssociations = new ArrayList();

            if (context.CreateObjectSet<T>().FirstOrDefault() != null)
            {
                System.Type oType = context.CreateObjectSet<T>().FirstOrDefault().GetType();

                foreach (PropertyInfo item in oType.GetProperties())
                {
                    if (item.PropertyType.Namespace == "BussinessLayer.Model")
                    {
                        oArrayListAssociations.Add(item.Name);
                    }
                }
            }
            return oArrayListAssociations;
        }

        #endregion Helper Method
    }
}