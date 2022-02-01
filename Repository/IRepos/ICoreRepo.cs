using System.Collections.Generic;

namespace TikoAPI.Repository.IRepos
{
    public interface ICoreRepo<T> where T : class
    {
        List<T> List();
        T Find(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}