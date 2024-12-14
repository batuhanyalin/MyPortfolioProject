using MyPortfolioProject.DataAccessLayer.Abstract;
using MyPortfolioProject.DataAccessLayer.Context;
using MyPortfolioProject.DataAccessLayer.Repositories;
using MyPortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.DataAccessLayer.EntityFramework
{
    public class EFAboutDAL:GenericRepository<About>,IAboutDAL
    {
        private readonly MyPortfolioContext _context;

        public EFAboutDAL(MyPortfolioContext context) : base(context)
        {
            _context = context;
        }
        public About GetAboutList()
        {
            var values=_context.Abouts.FirstOrDefault();
            return values;
        }
    }
}
