using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Post>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.Title).NotEmpty();
            RuleFor(p=>p.Title).Length(2,150);
            RuleFor(p=>p.Body).NotEmpty();
            
           // RuleFor(p => p.ProductName).Must(StartWithWithA);
        }

        private bool StartWithWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
