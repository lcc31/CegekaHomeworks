using Homework6.Database;
using Homework6.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Repositories
{
    public class EFRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly DbContext database;
        public EFRepository()
        {
            database = new DealershipContext();
            database.Database.EnsureCreated();
            database.Database.Migrate();
        }
        public void Delete(TEntity entity)
        {
            database.Set<TEntity>().Remove(entity);
            database.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return database.Set<TEntity>().AsNoTracking().AsEnumerable();
        }

        public TEntity GetById(Guid id)
        {
            return database.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            database.Set<TEntity>().Add(entity);
            database.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            database.Set<TEntity>().Update(entity);
            database.SaveChanges();

        }
    }
}
