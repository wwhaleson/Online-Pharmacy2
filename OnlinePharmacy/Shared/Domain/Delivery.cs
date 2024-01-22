
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OnlinePharmacy.Shared.Domain
{
    public class Delivery:IValidatableObject
    {
        [Required(ErrorMessage = "Delivery ID is required")]
        [Display(Name = "Delivery ID")]
        public int DeliveryID { get; set; }

        [Required(ErrorMessage = "Delivery Date is required")]
        [DataType(DataType.Date)]
        public DateTime? EstimatedDeliveryDate { get; set; }

        [Required(ErrorMessage = "Delivery Time is required")]
        [DataType(DataType.Time)]
        public DateTime? EstimatedDeliveryTime { get; set; }

        [Required(ErrorMessage = "Delivery Status is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Delivery Status does not meet length requirements")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Delivery Status should only contain alphabetic characters")]
        public string DeliveryStatus { get; set; }


        [Required(ErrorMessage = "Delivery Method is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Delivery Method does not meet length requirements")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Delivery Method should only contain alphabetic characters")]
        public string DeliveryMethod { get; set; }

        [Required(ErrorMessage = "Delivery Cost is required")]
        [Range(0.00, double.MaxValue, ErrorMessage = "Delivery Cost must be a valid cost")]
        public decimal DeliveryCost { get; set; }

        [Required(ErrorMessage = "Order ID is required")]
        public int OrderID { get; set; }

        public virtual Order? Order { get; set; }


        public int? StaffID { get; set; }

        public virtual Staff? Staff { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            if (EstimatedDeliveryDate != null)
            {
                if (EstimatedDeliveryDate <= DateTime.Now.Date)
                {
                    yield return new ValidationResult("Estimated Delivery Date must be today's date or later", new[] { "EstimatedDeliveryDate" });
                }

            }

            //throw new NotImplementedException();
            if (EstimatedDeliveryTime != null)
            {
                DateTime currentTime = DateTime.Now;

                if (EstimatedDeliveryTime.Value.TimeOfDay <= currentTime.TimeOfDay)
                {
                    yield return new ValidationResult("Estimated Delivery Time must be later than the current time", new[] { "EstimatedDeliveryTime" });
                }
            }

        }

    }
}