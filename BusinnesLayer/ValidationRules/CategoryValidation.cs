using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class CategoryValidation : AbstractValidator<Categories>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.Category_Name).NotEmpty().WithMessage("Kategori Boş Geçmezsiniz");
        }
    }
}
