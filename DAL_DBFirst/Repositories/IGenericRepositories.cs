using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_CodeFirst.Repositories
{
    public interface IGenericRepositories<T> where T : class
    {
        List<T> GetAll();
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(T obj);

    }
}
