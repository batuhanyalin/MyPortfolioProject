﻿using MyPortfolioProject.DataAccessLayer.Abstract;
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
    public class EFProjectDAL:GenericRepository<Project>,IProjectDAL
    {
        private readonly MyPortfolioContext _context;

        public EFProjectDAL(MyPortfolioContext context) : base(context)
        {
            _context = context;
        }
    }
}
