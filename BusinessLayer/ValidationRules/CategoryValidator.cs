using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public  class CategoryValidator:AbstractValidator<Category>
    {
        public  CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori Adı yazınız.");
            RuleFor(x => x.CategoryDesciption).NotEmpty().WithMessage("Lütfen Kategori Açıklaması yazınız.");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter olacak şekilde deoldurunuz. ");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter olacak şekilde deoldurunuz. ");
            RuleFor(x => x.CategoryDesciption).MinimumLength(20).WithMessage("Lütfen en az 30 karakter olacak şekilde deoldurunuz. ");
            RuleFor(x => x.CategoryDesciption).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter olacak şekilde deoldurunuz. ");
        }
    }
}
