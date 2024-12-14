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
    public class SkillManager : ISkillService
    {
        private readonly ISkillDAL _SkillDAL;

        public SkillManager(ISkillDAL SkillDAL)
        {
            _SkillDAL = SkillDAL;
        }

        public void TDelete(int id)
        {
            _SkillDAL.Delete(id);
        }

        public Skill TGetById(int id)
        {
            return _SkillDAL.GetById(id);
        }

        public List<Skill> TGetListAll()
        {
            return _SkillDAL.GetListAll();
        }

        public void TInsert(Skill t)
        {
            _SkillDAL.Insert(t);
        }

        public void TUpdate(Skill t)
        {
            _SkillDAL.Update(t);
        }
    }
}
