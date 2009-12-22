using QuickPharma.Core.Repositories;
using QuickPharma.Core;
using NHibernate;
using NHibernate.Cfg;
using System.Collections.Generic;
using NHibernate.Criterion;

namespace QuickPharma.Infrastructure.NHibernate
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected ISession Session { get; set; }
        
        public Repository()
        {
            this.Session = NHibernateHelper.GetSession();
        }
        
        public void Add(TEntity entity)
        {
            this.Session.Save(entity);
        }

        public void Delete(TEntity entity)
        {
            this.Session.Delete(entity);
        }

        public TEntity GetById(int id)
        {
            return this.Session.Get<TEntity>(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            ICriteria crit = this.Session.CreateCriteria<TEntity>();
            return crit.List<TEntity>();
        }
    }
}
