using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class ProductValidation : AbstractValidator<Products>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Product_Name).NotEmpty().WithMessage("Boş Alan Boş Geçmezsiniz");
        }
    }
}
