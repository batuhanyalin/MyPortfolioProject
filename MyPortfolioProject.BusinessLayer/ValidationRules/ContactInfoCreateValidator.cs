using FluentValidation;
using MyPortfolioProject.DtoLayer.ContactInfoDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.BusinessLayer.ValidationRules
{
    public class ContactInfoCreateValidator:AbstractValidator<ContactInfoCreateDto>
    {
        public ContactInfoCreateValidator()
        {
            RuleFor(x => x.Title)
              .NotEmpty().WithMessage("Title is required.")
              .Length(2, 50).WithMessage("Title must be between 2 and 50 characters.");

            RuleFor(x => x.UrlText)
                .NotEmpty().WithMessage("UrlText is required.")
                .Length(2, 50).WithMessage("UrlText must be between 2 and 50 characters.");

            RuleFor(x => x.Url)
                .NotEmpty().WithMessage("Url is required.");

            RuleFor(x => x.Icon)
                .NotEmpty().WithMessage("Icon is required.");
        }
    }
}
