using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Application.Features.Language.Commands.UpdateProgrammingLanguage
{
    public class UpdateProgrammingLanguageCommandValidator : AbstractValidator<UpdateProgrammingLanguageCommand>
    {
        public UpdateProgrammingLanguageCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(1);
        }
    }
}
