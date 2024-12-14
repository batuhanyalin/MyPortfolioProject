using FluentValidation;
using MyPortfolioProject.DtoLayer.ContactDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolioProject.BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<ContactCreateDto>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Name)
              .NotEmpty().WithMessage("Name is required.")
              .Length(2, 50).WithMessage("Name must be between 2 and 50 characters.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname is required.")
                .Length(2, 50).WithMessage("Surname must be between 2 and 50 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.Subject)
                .NotEmpty().WithMessage("Subject is required.");

            RuleFor(x => x.Text)
                .NotEmpty().WithMessage("Message text is required.")
                .Length(10, 500).WithMessage("Message must be between 10 and 500 characters.");
        }
    }
}
