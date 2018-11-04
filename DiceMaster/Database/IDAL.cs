using System.Collections.Generic;
using DiceMaster.Models;
using System.IO;

namespace DiceMaster.Database
{
    public interface IDAL
    {
        T Get<T>(string id) where T : RavenModel;
        List<T> GetAll<T>() where T : RavenModel;
        T Update<T>(T obj) where T : RavenModel;
        T Create<T>(T obj) where T : RavenModel;
        T Delete<T>(string id) where T : RavenModel;
    }
}
