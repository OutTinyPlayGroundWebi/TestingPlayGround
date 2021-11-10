using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FluentValidation;

namespace AppCatalogService.Core.Application.Services.Example
{
    public class CreateCommandValidator : AbstractValidator<CreateCommand>
    {
        public CreateCommandValidator()
        {
            //ToDo: CreateCommand should be cast to ExampleEntity

            // Example Validations below

            //RuleFor(v => v.Id).NotEmpty().GreaterThan(0);
            //RuleFor(i => i.IdentCode)
            //    .NotEmpty()
            //    .Length(11)
            //    .Must(i=>i.All(char.IsDigit))
            //    .WithMessage(i => LocalizationResources.ValidationError_OnlyDigits);

            //RuleFor(i=>i.FirstName)
            //    .NotEmpty()
            //    .MinimumLength(2)
            //    .MaximumLength(500)
            //    .Must(i=> i.All(char.IsLetter))
            //    .WithMessage(x => LocalizationResources.ValidationError_OnlyLetters)
            //    .SetValidator(new PersonNameLettersValidator())
            //    .WithMessage(x => LocalizationResources.ValidationError_OnlyGeorgianOrLatin);

            //RuleFor(i => i.LastName)
            //    .NotEmpty()
            //    .MinimumLength(2)
            //    .MaximumLength(500)
            //    .Must(i => i.All(char.IsLetter))
            //    .WithMessage(x => LocalizationResources.ValidationError_OnlyLetters)
            //    .SetValidator(new PersonNameLettersValidator())
            //    .WithMessage(x => LocalizationResources.ValidationError_OnlyGeorgianOrLatin);

            //    RuleFor(i => i.BirthDate)
            //        .NotEmpty()
            //        .Must(i => i.GetAge() >= 18)
            //        .WithMessage(x => LocalizationResources.ValidationError_Person_Min18);

            //RuleForEach(x => x.PhoneBook.Select(i=>i.Number)) // ამის გატანაც შეიძლება ცალკე ვალიდატორად
            //    .MinimumLength(4)
            //    .MaximumLength(50)
            //    .OverridePropertyName(LocalizationResources.ValidationPropertyName_PhoneNumber);
        }
    }

   

}
