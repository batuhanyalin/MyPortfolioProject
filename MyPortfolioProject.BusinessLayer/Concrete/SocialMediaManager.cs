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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _SocialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL SocialMediaDAL)
        {
            _SocialMediaDAL = SocialMediaDAL;
        }

        public void TDelete(int id)
        {
            _SocialMediaDAL.Delete(id);
        }

        public SocialMedia TGetById(int id)
        {
            return _SocialMediaDAL.GetById(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _SocialMediaDAL.GetListAll();
        }

        public void TInsert(SocialMedia t)
        {
            _SocialMediaDAL.Insert(t);
        }

        public void TUpdate(SocialMedia t)
        {
            _SocialMediaDAL.Update(t);
        }
    }
}
