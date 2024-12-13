using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Update(T t);
        void Insert(T t);
        void Delete(int id);
        T GetById(int id);
        List<T> GetListAll();
    }
}
