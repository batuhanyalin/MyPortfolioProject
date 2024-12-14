using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DataAccessLayer.Abstract;
using MyPortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _ServiceDAL;

        public ServiceManager(IServiceDAL ServiceDAL)
        {
            _ServiceDAL = ServiceDAL;
        }

        public void TDelete(int id)
        {
            _ServiceDAL.Delete(id);
        }

        public Service TGetById(int id)
        {
            return _ServiceDAL.GetById(id);
        }

        public List<Service> TGetListAll()
        {
            return _ServiceDAL.GetListAll();
        }

        public void TInsert(Service t)
        {
            _ServiceDAL.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _ServiceDAL.Update(t);
        }
    }
}
