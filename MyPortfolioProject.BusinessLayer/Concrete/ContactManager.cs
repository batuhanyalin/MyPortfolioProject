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
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _ContactDAL;

        public ContactManager(IContactDAL ContactDAL)
        {
            _ContactDAL = ContactDAL;
        }

        public void TDelete(int id)
        {
            _ContactDAL.Delete(id);
        }

        public Contact TGetById(int id)
        {
            return _ContactDAL.GetById(id);
        }

        public List<Contact> TGetListAll()
        {
            return _ContactDAL.GetListAll();
        }

        public void TInsert(Contact t)
        {
            _ContactDAL.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _ContactDAL.Update(t);
        }
    }
}
