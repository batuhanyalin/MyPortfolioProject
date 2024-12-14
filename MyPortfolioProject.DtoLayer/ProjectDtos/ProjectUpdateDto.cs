using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.DtoLayer.ProjectDtos
{
    public class ProjectUpdateDto
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
    }
}
