using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Category
    {
        [Required(ErrorMessage = "Category ID is required")]
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Category Name does not meet length requiremnts")]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Category Description does not meet length requiremnts")]
        public string CategoryDescription { get; set; }


    }
}