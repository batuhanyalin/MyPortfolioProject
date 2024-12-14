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
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDAL _ProjectDAL;

        public ProjectManager(IProjectDAL ProjectDAL)
        {
            _ProjectDAL = ProjectDAL;
        }

        public void TDelete(int id)
        {
            _ProjectDAL.Delete(id);
        }

        public Project TGetById(int id)
        {
            return _ProjectDAL.GetById(id);
        }

        public List<Project> TGetListAll()
        {
            return _ProjectDAL.GetListAll();
        }

        public void TInsert(Project t)
        {
            _ProjectDAL.Insert(t);
        }

        public void TUpdate(Project t)
        {
            _ProjectDAL.Update(t);
        }
    }
}
