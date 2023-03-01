using DAL_CodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_CodeFirst.Repositories
{
    public class GenericRepositories<T> : IGenericRepositories<T> where T : class
    {
        private readonly FpolyDBContext _context;

        private DbSet<T> _table { get; set; }

        public GenericRepositories(FpolyDBContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public bool Add(T obj)
        {
            if(obj == null) return false;
            _table.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(T obj)
        {
            if (obj == null) return false;
            _table.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public bool Update(T obj)
        {
            if (obj == null) return false;
            _table.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
