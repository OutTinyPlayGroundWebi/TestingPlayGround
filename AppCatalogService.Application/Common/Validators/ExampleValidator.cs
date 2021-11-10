using FluentValidation;
using FluentValidation.Validators;
using System.Threading;
using System.Threading.Tasks;

namespace AppCatalogService.Core.Application.Common.Validators
{

    public class ExampleValidator<T, TProperty> : AsyncPropertyValidator<T, TProperty>
    {
        public override string Name => "ExampleValidatorValidator";

        public override async Task<bool> IsValidAsync(ValidationContext<T> context, TProperty value, CancellationToken cancellation)
        {
            throw new System.NotImplementedException();
            return value != null;
        }
               
        protected override string GetDefaultMessageTemplate(string errorCode)
          => "A value for {PropertyName} failed example validation ";
    }

    // [Deprecated] keeping here it may help with ToDo.txt -> 3
    //public class ExampleValidator : PropertyValidator
    //{
    //    protected override bool IsValid(PropertyValidatorContext context)
    //    {
    //        if (string.IsNullOrWhiteSpace(context.PropertyValue.ToString())) return true;
    //        return context.PropertyValue.ToString().IsGeorgianString() || context.PropertyValue.ToString().IsLatinString();
    //    }
    //}
}
