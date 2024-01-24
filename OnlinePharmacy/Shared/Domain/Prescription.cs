using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Prescription : IValidatableObject
    {
        [Required(ErrorMessage = "Prescription ID is required")]
        [Display(Name = "Prescription ID")]
        public int PrescriptionID { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Issue Date is required")]
        [Display(Name = "Issue Date")]
        public DateTime? IssueDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Expiry Date is required")]
        [Display(Name = "Expiry Date")]
        public DateTime? ExpiryDate { get; set; }

        [Required(ErrorMessage = "Online Consultation ID is required")]
        [Display(Name = "Online Consultation ID")]
        public int OnlineConsultationID { get; set; }

        public virtual OnlineConsultation? OnlineConsultation { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            //throw new NotImplementedException();
            if (IssueDate != null)
            {
                if (IssueDate >= ExpiryDate)
                {
                    yield return new ValidationResult("Issue Date must be greater than Expiry Date", new[] { "Issue Date" });
                }
            }

            //throw new NotImplementedException();
            if (IssueDate != null)
            {
                if (DateTime.Now <= IssueDate)
                {
                    yield return new ValidationResult("DateTime.Now must be greater than Issue Date", new[] { "DateTime.Now" });
                }
            }

            DateTime today = DateTime.Today;

            if (IssueDate != null && IssueDate < today)
            {
                yield return new ValidationResult("Issue Date must be today or in the future", new[] { "IssueDate" });
            }

            if (ExpiryDate != null && ExpiryDate < today)
            {
                yield return new ValidationResult("Expiry Date must be today or in the future", new[] { "ExpiryDate" });
            }



        }


    }
}