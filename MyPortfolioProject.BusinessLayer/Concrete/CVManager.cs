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
    public class CVManager : ICVService
    {
        private readonly ICVDAL _CVDAL;

        public CVManager(ICVDAL CVDAL)
        {
            _CVDAL = CVDAL;
        }

        public void TDelete(int id)
        {
            _CVDAL.Delete(id);
        }

        public CV TGetById(int id)
        {
            return _CVDAL.GetById(id);
        }

        public List<CV> TGetListAll()
        {
            return _CVDAL.GetListAll();
        }

        public void TInsert(CV t)
        {
            _CVDAL.Insert(t);
        }

        public void TUpdate(CV t)
        {
            _CVDAL.Update(t);
        }
    }
}
