using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Categories
    {
      [Key]    
       public int Category_Id { get; set; }

       public string? Category_Name { get; set; }

       public bool? Category_Status { get; set; }

       public virtual List<Products>?Products { get; set; }
    }
}
