using FluentValidation;
using MyPortfolioProject.DtoLayer.ResumeDtos;
using MyPortfolioProject.DtoLayer.SocialMediaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.BusinessLayer.ValidationRules
{
    public class SocialMediaUpdateValidator : AbstractValidator<SocialMediaUpdateDto>
    {
        public SocialMediaUpdateValidator()
        {
            RuleFor(x => x.Name)
              .NotEmpty().WithMessage("Name is required.")
              .Length(2, 50).WithMessage("Name must be between 2 and 50 characters.");

            RuleFor(x => x.Icon)
                .NotEmpty().WithMessage("Icon is required.");

            RuleFor(x => x.Url)
                .NotEmpty().WithMessage("Url text is required.")
                .Length(10, 500).WithMessage("Url must be between 10 and 500 characters.");
        }
    }
}
