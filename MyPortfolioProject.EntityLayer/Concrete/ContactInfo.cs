﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.EntityLayer.Concrete
{
    public class ContactInfo
    {
        public int ContactInfoId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public string UrlText { get; set; }
    }
}
