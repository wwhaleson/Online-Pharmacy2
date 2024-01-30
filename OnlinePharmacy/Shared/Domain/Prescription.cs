﻿using System;
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
        public int? OnlineConsultationID { get; set; }
        public virtual OnlineConsultation? OnlineConsultation { get; set; }

        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            DateTime today = DateTime.Today;

            if (IssueDate != null && IssueDate != today)
            {
                yield return new ValidationResult("Issue Date must be today", new[] { "IssueDate" });
            }

            if (ExpiryDate != null && (IssueDate == null || ExpiryDate <= IssueDate))
            {
                yield return new ValidationResult("Expiry Date must be later than Issue Date", new[] { "ExpiryDate" });
            }


        }

    }
}