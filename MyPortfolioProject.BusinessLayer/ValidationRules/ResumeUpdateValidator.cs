using FluentValidation;
using MyPortfolioProject.DtoLayer.ResumeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.BusinessLayer.ValidationRules
{
    public class ResumeUpdateValidator : AbstractValidator<ResumeUpdateDto>
    {
        public ResumeUpdateValidator()
        {
            RuleFor(x => x.Title)
                  .NotEmpty().WithMessage("Title is required.")
                  .Length(2, 50).WithMessage("Title must be between 2 and 50 characters.");

            RuleFor(x => x.Location)
                .NotEmpty().WithMessage("Location is required.");

            RuleFor(x => x.Date)
                .NotEmpty().WithMessage("Date is required.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description text is required.")
                .Length(10, 500).WithMessage("Description must be between 10 and 500 characters.");
        }
    }
}
