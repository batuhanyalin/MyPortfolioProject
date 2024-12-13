using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TUpdate(T entity);
        void TInsert(T entity);
        void TDelete(int id);
        T TGetById(int id);
        List<T> TGetListAll();
    }
}
