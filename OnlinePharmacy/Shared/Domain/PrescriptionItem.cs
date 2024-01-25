
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class PrescriptionItem
    {
        [Required(ErrorMessage = "Prescription Item ID is required")]
        [Display(Name = "Prescription Item ID")]
        public int PrescriptionItemID { get; set; }

        [Required]
        [Display(Name = "Prescription Item Quantity")]
        [Range(1, int.MaxValue, ErrorMessage = "Prescription Item Quantity must be greater than 0")]
        public int? PrescriptionItemQuantity { get; set; }

        [Required]
        [Display(Name = "Prescription Item Subtotal")]
        [DataType(DataType.Currency)]
        [Range(0.01, double.MaxValue, ErrorMessage = "Prescription Item Subtotal must be greater than 0")]
        public decimal? PrescriptionItemSubTotal { get; set; }

        [Display(Name = "Prescription ID")]
        public int? PrescriptionID { get; set; }

        public virtual Prescription? Prescription { get; set; }


        public int ProductID { get; set; }

        public virtual Product? Product { get; set; }

        [Required]
        [Display(Name = "Order ID")]
        public int? OrderID { get; set; }

        public virtual Order Order { get; set; }

    }
}