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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TDelete(int id)
        {
            _aboutDAL.Delete(id);
        }

        public About TGetAboutList()
        {
            return _aboutDAL.GetAboutList();
        }

        public About TGetById(int id)
        {
            return _aboutDAL.GetById(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutDAL.GetListAll();
        }

        public void TInsert(About t)
        {
            _aboutDAL.Insert(t);
        }

        public void TUpdate(About t)
        {
            _aboutDAL.Update(t);
        }
    }
}
