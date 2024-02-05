using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Product : IValidatableObject
    {
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "Product Name does not meet length requirements")]
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Product Brand does not meet length requirements")]
        [Display(Name = "Product Brand")]
        public string? ProductBrand { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Product Ingredient does not meet length requirements")]
        [Display(Name = "Product Ingredients")]
        public string? ProductIngredients { get; set; }

        [Required]
        [Display(Name = "Product Expiry Date")]
        [DataType(DataType.Date)]
        public DateTime? ProductExpiryDate { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Product Dosage does not meet length requirements")]
        [Display(Name = "Product Dosage")]
        public string? ProductDosage { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Product Usage does not meet length requirements")]
        [Display(Name = "Product Usage")]
        public string? ProductUsage { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Product Description does not meet length requirements")]
        [Display(Name = "Product Description")]
        public string? ProductDescription { get; set; }

        [Required]
        [Display(Name = "Product Minimum Age")]
        [Range(0, int.MaxValue, ErrorMessage = "Product Minimum Age must be greater than or equal to 0")]
        public int? ProductMinimumAge { get; set; }

        [Required]
        [Display(Name = "Product Maximum Age")]
        [Range(0, int.MaxValue, ErrorMessage = "Product Maximum Age must be greater than or equal to 0")]
        public int? ProductMaximumAge { get; set; }

        [Required]
        [Display(Name = "Product Image")]
        [RegularExpression(@"\b(?:https?|ftp):\/\/\S+\.(png|jpg|jpeg|gif|bmp)\b", ErrorMessage = "Invalid image URL or file path")]
        public string? ProductImage { get; set; }

        [Required]
        [Display(Name = "Prescription Status")]
        public bool PrescriptionStatus { get; set; }

        [Required(ErrorMessage = "Product Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Product Price must be greater than 0")]
        [DataType(DataType.Currency)]
        public decimal? ProductPrice { get; set; }

        
        [Required(ErrorMessage = "Stock Available field is required")]
        [Display(Name = "Stock Availability")]
        public bool? StockAvailable { get; set; }


        [Required(ErrorMessage = "Product Category ID is required")]
        [Display(Name = "Product Category ID")]
        public int? ProductCategoryID { get; set; }
        public virtual Category? Category { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            //throw new NotImplementedException();
            if (ProductMinimumAge != null)
            {
                if (ProductMaximumAge < ProductMinimumAge)
                {
                    yield return new ValidationResult("Product Minimum Age must be greater than Product Maximum Age", new[] { "ProductMaximumAge" });
                }
            }

            // Check if ProductExpiryDate is at least 2 years later
            if (ProductExpiryDate != null && ProductExpiryDate <= DateTime.Now.AddYears(2))
            {
                yield return new ValidationResult("Product Expiry Date must be at least 2 years later from the current date", new[] { "ProductExpiryDate" });
            }


        }
    }
}