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
    public class ResumeManager : IResumeService
    {
        private readonly IResumeDAL _ResumeDAL;

        public ResumeManager(IResumeDAL ResumeDAL)
        {
            _ResumeDAL = ResumeDAL;
        }

        public void TDelete(int id)
        {
            _ResumeDAL.Delete(id);
        }

        public Resume TGetById(int id)
        {
            return _ResumeDAL.GetById(id);
        }

        public List<Resume> TGetListAll()
        {
            return _ResumeDAL.GetListAll();
        }

        public void TInsert(Resume t)
        {
            _ResumeDAL.Insert(t);
        }

        public void TUpdate(Resume t)
        {
            _ResumeDAL.Update(t);
        }
    }
}
