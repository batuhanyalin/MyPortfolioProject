using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.DtoLayer.ServiceDtos
{
    public class ServiceCreateDto
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string? Url { get; set; }
    }
}
