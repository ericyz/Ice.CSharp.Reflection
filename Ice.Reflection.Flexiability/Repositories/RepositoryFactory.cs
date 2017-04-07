using System;
using System.Linq;
using System.Reflection;
using Ice.Reflection.Flexiability.Repositories.Interface;

namespace Ice.Reflection.Flexiability.Repositories
{
    public class RepositoryFactory
    {
      public  IRepository<T> GetRepository<T>(){
        return IocContainer.GetService<IRepository<T>>();
      }
    }

    public class IocContainer{
        public static T  GetService<T>(){
            var type = Assembly.GetEntryAssembly().ExportedTypes.Where(s=>s.GetInterfaces().Any(x=>x == typeof(T))).FirstOrDefault();
            var instance = (T)Activator.CreateInstance(type);
            return instance;
        }
    }
}