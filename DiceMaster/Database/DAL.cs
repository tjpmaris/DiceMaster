using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiceMaster.Models;
using Raven.Client.Documents;

namespace DiceMaster.Database
{
    public class DAL : IDAL
    {

        public async Task<T> Get<T>(string id) where T : RavenModel
        {
            using (var session = DocumentStoreHolder.Store.OpenAsyncSession())
            {
                return await session.LoadAsync<T>(id);
            }
        }

        public async Task<List<T>> GetAll<T>() where T : RavenModel
        {
            using (var session = DocumentStoreHolder.Store.OpenAsyncSession())
            {
                
                return await session.Query<T>().ToListAsync();
            }
        }

        public async Task<T> Update<T>(T obj) where T : RavenModel
        {
            using(var session = DocumentStoreHolder.Store.OpenAsyncSession())
            {
                var doc = await session.LoadAsync<T>(obj.Id);

                if(doc != null)
                {
                    doc.Update(obj);
                    await session.SaveChangesAsync();
                }

                return doc;
            }
        }

        public async Task<T> Create<T>(T obj) where T : RavenModel
        {
            using (var session = DocumentStoreHolder.Store.OpenAsyncSession())
            {
                obj.Id = Guid.NewGuid().ToString();

                await session.StoreAsync(obj, obj.Id);
                
                return obj;
            }
        }

        public async Task<T> Delete<T>(string id) where T : RavenModel
        {
            using(var session = DocumentStoreHolder.Store.OpenAsyncSession())
            {
                var doc = await session.LoadAsync<T>(id);

                if (doc != null)
                {
                    session.Delete(doc);
                    await session.SaveChangesAsync();
                }

                return doc;
            }
        }
    }
}
