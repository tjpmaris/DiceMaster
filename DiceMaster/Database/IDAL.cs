using System.Collections.Generic;
using System.Threading.Tasks;
using DiceMaster.Models;

namespace DiceMaster.Database
{
    public interface IDAL
    {
        Task<T> Get<T>(string id) where T : RavenModel;
        Task<List<T>> GetAll<T>() where T : RavenModel;
        Task<T> Update<T>(T obj) where T : RavenModel;
        Task<T> Create<T>(T obj) where T : RavenModel;
        Task<T> Delete<T>(string id) where T : RavenModel;
    }
}
