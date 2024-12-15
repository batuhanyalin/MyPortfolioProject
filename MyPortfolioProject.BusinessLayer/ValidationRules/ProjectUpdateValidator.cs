using FluentValidation;
using MyPortfolioProject.DtoLayer.ProjectDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.BusinessLayer.ValidationRules
{
    public class ProjectUpdateValidator : AbstractValidator<ProjectUpdateDto>
    {
        public ProjectUpdateValidator()
        {
            RuleFor(x => x.Title)
              .NotEmpty().WithMessage("Name is required.")
              .Length(2, 100).WithMessage("Name must be between 2 and 100 characters.");

            RuleFor(x => x.Url)
                .NotEmpty().WithMessage("Url is required.");

            RuleFor(x => x.Date)
                .NotEmpty().WithMessage("Date is required.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Message text is required.")
                .Length(10, 280).WithMessage("Message must be between 10 and 280 characters.");
        }
    }
}
