using Homework6.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Repositories
{
    public class MongoDbRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IMongoDatabase database;
        private IMongoCollection<TEntity> collection => database.GetCollection<TEntity>(typeof(TEntity).Name);
        public MongoDbRepository()
        {
            var client = new MongoClient("mongodb+srv://lcc31:Agapi999*@cluster0.ed6ab.mongodb.net/test");

            database = client.GetDatabase("dealership");
        }
        public void Insert(TEntity entity)
        {
            collection.InsertOne(entity);
        }
        public TEntity GetById(Guid Id)
        {
            return collection.Find(e => e.Id == Id).SingleOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return collection.Find(e => true).ToEnumerable();
        }

        public void Delete(TEntity entity)
        {
            collection.DeleteOne(e => e.Id == entity.Id);
        }

        public void Update(TEntity entity)
        {
            collection.ReplaceOne(e => e.Id == entity.Id, entity);
        }
    }
}
