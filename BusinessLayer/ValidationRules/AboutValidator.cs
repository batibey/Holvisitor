using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
		public AboutValidator()
		{
			RuleFor(x => x.Description).NotEmpty().WithMessage("Description Required");
			RuleFor(x => x.Image1).NotEmpty().WithMessage("Please Image Select");
			RuleFor(x => x.Description).MinimumLength(20).WithMessage("Minimum 20 Character");
			RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Maximum 1000 Character");
		}
	}
}

