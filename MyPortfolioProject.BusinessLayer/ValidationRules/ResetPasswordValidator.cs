using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPortfolioProject.DtoLayer.IdentityDtos;

namespace MyPortfolioProject.BusinessLayer.ValidationRules
{
    public class ResetPasswordValidator:AbstractValidator<ResetPasswordDto>
    {
        public ResetPasswordValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be blank.").MinimumLength(6).WithMessage("Password must be at least 6 characters.").MaximumLength(12).WithMessage("Password can be a maximum of 12 characters.");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Confirm password cannot be left blank.").Equal(x=>x.Password).WithMessage("Password must be the same as the confirm password.");
        }
    }
}
