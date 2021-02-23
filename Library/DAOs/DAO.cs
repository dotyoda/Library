using Library.Models;
using Library.Settings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.DAOs
{
    class DAO<T, I> : IDAO<T, I>, IDisposable where T : Model<I>
    {
        public DAO()
        {
            conn = new EntityConnection<T, I>();
        }

        public readonly EntityConnection<T, I> conn;

        public virtual T Save(T entity)
        {
            T found = conn.Entity.Find(entity.Id);

            if (found == null)
            {
                conn.Entity.Add(entity);
                conn.SaveChanges();
            }
            else
            {
                conn.Entry(found).CurrentValues.SetValues(entity);
                conn.SaveChanges(); 
            }

            return entity;
        }

        public virtual T GetById(I id)
        {
            return conn.Entity.Find(id);
        }

        public virtual List<T> GetAll()
        {
            List<T> entities = conn.Entity.ToList();

            if (entities.Count == 0) return null;

            return entities;
        }

        public virtual bool Delete(I id)
        {
            T entity = conn.Entity.Find(id);

            conn.Entity.Remove(entity);
            conn.SaveChanges();

            entity = conn.Entity.Find(id);

            if (entity != null) return false;

            return true;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            conn.Dispose();
        }
    }
}
