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
    public class OnlineConsultation : IValidatableObject
    {
        [Required(ErrorMessage = "Online Consultation ID is required")]
        [Display(Name = "Online Consultation ID")]
        public int OnlineConsultationID { get; set; }

        [Required(ErrorMessage = "Consultation Time Start is required")]
        [DataType(DataType.Time)]
        public DateTime? ConsultationTimeStart { get; set; }

        [Required(ErrorMessage = "Consultation Time End is required")]
        [DataType(DataType.Time)]
        public DateTime? ConsultationTimeEnd { get; set; }

        [Required(ErrorMessage = "Consultation Date Start is required")]
        [DataType(DataType.Date)]
        public DateTime? ConsultationDateStart { get; set; }

        [Required(ErrorMessage = "Consultation Date End is required")]
        [DataType(DataType.Date)]
        public DateTime? ConsultationDateEnd { get; set; }

        [Required(ErrorMessage = "Consultation Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Consultation Price must be greater than 0")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Consultation Price should have up to two decimal places")]
        [DataType(DataType.Currency)]
        public decimal? ConsultationPrice { get; set; }

        [Required(ErrorMessage = "Consultation Symptom is required")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "Consultation Symptom length should be between 5 and 255")]
        public string? ConsultationSymptom { get; set; }

        [Required(ErrorMessage = "Consultation Diagnosis is required")]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "Consultation Diagnosis length should be between 5 and 255")]
        public string? ConsultationDiagnosis { get; set; }

        [Required(ErrorMessage = "Consultation Status is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Consultation Status length should be between 2 and 50")]
        public string? ConsultationStatus { get; set; }

        [Required(ErrorMessage = "Consultation Platform is required")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Consultation Platform length should be between 2 and 50")]
        public string? ConsultationPlatform { get; set; }

        [Required(ErrorMessage = "Customer ID is required")]
        [Display(Name = "Customer ID")]
        public int? CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }

        [Required(ErrorMessage = "Pharmacist ID is required")]
        [Display(Name = "Pharmacist ID")]
        public int? PharmacistID { get; set; }
        public virtual Staff? Staff { get; set; } 

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ConsultationDateStart != null && ConsultationDateEnd != null)
            {
                if (ConsultationDateStart > ConsultationDateEnd)
                {
                    yield return new ValidationResult("Consultation Date Start must be earlier than or equal to Consultation Date End", new[] { "ConsultationDateStart" });
                }

                // Check if ConsultationDateStart and ConsultationDateEnd are on the same day
                if (ConsultationDateStart.Value.Date != ConsultationDateEnd.Value.Date)
                {
                    yield return new ValidationResult("Consultation Date Start and Date End must be on the same day", new[] { "ConsultationDateStart", "ConsultationDateEnd" });
                }

                // Check if ConsultationTimeStart is greater than or equal to ConsultationTimeEnd
                if (ConsultationTimeStart >= ConsultationTimeEnd)
                {
                    yield return new ValidationResult("Consultation Time Start must be earlier than Consultation Time End", new[] { "ConsultationTimeStart" });
                }

                // Check if ConsultationTimeStart and ConsultationTimeEnd are within the allowed time range (9 am to 9 pm)
                TimeSpan startTime = ConsultationTimeStart.Value.TimeOfDay;
                TimeSpan endTime = ConsultationTimeEnd.Value.TimeOfDay;

                TimeSpan allowedStartTime = new TimeSpan(9, 0, 0); // 9 am
                TimeSpan allowedEndTime = new TimeSpan(21, 0, 0); // 9 pm

                if (startTime < allowedStartTime || endTime > allowedEndTime)
                {
                    yield return new ValidationResult("Consultation times must be between 9 am and 9 pm", new[] { "ConsultationTimeStart", "ConsultationTimeEnd" });
                }
            }

        }

    }
}