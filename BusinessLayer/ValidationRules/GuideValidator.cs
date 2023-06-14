using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please Guide Name Entry");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please Guide Description Entry");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please Guide Image Entry");
            
        }
    }
}
