using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class ProductViewModel
    {
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }

        //[ValidateNever]
        public Product Product { get; set; }   
    }
}
