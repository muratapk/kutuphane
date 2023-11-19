using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Products
    {
        [Key]
        public int Product_Id { get; set; }

        public string? Product_Name { get; set; } 

        public string? Product_Picture { get; set; }

        public string? Product_Description { get; set; }


        public int? Category_Id{get;set; }

        public virtual Categories? Categories{ get; set; } 
        [NotMapped]
        public IFormFile? Image_Upload { get; set; }
    }
}
