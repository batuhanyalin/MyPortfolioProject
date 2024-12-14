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
    public class ContactInfoManager : IContactInfoService
    {
        private readonly IContactInfoDAL _ContactInfoDAL;

        public ContactInfoManager(IContactInfoDAL ContactInfoDAL)
        {
            _ContactInfoDAL = ContactInfoDAL;
        }

        public void TDelete(int id)
        {
            _ContactInfoDAL.Delete(id);
        }

        public ContactInfo TGetById(int id)
        {
            return _ContactInfoDAL.GetById(id);
        }

        public List<ContactInfo> TGetListAll()
        {
            return _ContactInfoDAL.GetListAll();
        }

        public void TInsert(ContactInfo t)
        {
            _ContactInfoDAL.Insert(t);
        }

        public void TUpdate(ContactInfo t)
        {
            _ContactInfoDAL.Update(t);
        }
    }
}
