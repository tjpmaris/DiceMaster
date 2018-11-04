using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DiceMaster.Models;

namespace DiceMaster.Database
{
    public class DAL : IDAL
    {

        public T Get<T>(string id) where T : RavenModel
        {
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                return session.Load<T>(id);
            }
        }

        public List<T> GetAll<T>() where T : RavenModel
        {
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                return session.Query<T>().ToList();
            }
        }

        public T Update<T>(T obj) where T : RavenModel
        {
            using(var session = DocumentStoreHolder.Store.OpenSession())
            {
                var doc = session.Load<T>(obj.Id);

                if(doc != null)
                {
                    doc.Update(obj);
                    session.SaveChanges();
                }

                return doc;
            }
        }

        public T Create<T>(T obj) where T : RavenModel
        {
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                obj.Id = Guid.NewGuid().ToString();

                session.Store(obj, obj.Id);
                session.SaveChanges();
                
                return obj;
            }
        }

        public T Delete<T>(string id) where T : RavenModel
        {
            using(var session = DocumentStoreHolder.Store.OpenSession())
            {
                var doc = session.Load<T>(id);

                if (doc != null)
                {
                    session.Delete(doc);
                    session.SaveChanges();
                }

                return doc;
            }
        }
    }
}
