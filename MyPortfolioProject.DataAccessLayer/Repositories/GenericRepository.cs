using MyPortfolioProject.DataAccessLayer.Abstract;
using MyPortfolioProject.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly MyPortfolioContext _context;

        public GenericRepository(MyPortfolioContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
           
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Set<T>().Update(t);
            _context.SaveChanges();
        }
    }
}
