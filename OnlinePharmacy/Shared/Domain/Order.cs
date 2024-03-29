﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacy.Shared.Domain
{
    public class Order
    {
        [Required(ErrorMessage = "Order ID is required")]
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Order Date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime? OrderDate { get; set; }

        [Required(ErrorMessage = "Order Time is required")]
        [DataType(DataType.Time)]
        [Display(Name = "Order Time")]
        public DateTime? OrderTime { get; set; }

        [Required(ErrorMessage = "Total Cost is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total Cost must be greater than 0")]
        [DataType(DataType.Currency)]
        [Display(Name = "Total Cost")]
        public decimal? TotalCost { get; set; }

        [Required(ErrorMessage = "Payment Type is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Payment Type does not meet length requirements")]
        [Display(Name = "Payment Type")]
        public string? PaymentType { get; set; }

        [Required(ErrorMessage = "Customer ID is required")]
        [Display(Name = "Customer ID")]
        public int? CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }

        [Required(ErrorMessage = "Staff ID is required")]
        [Display(Name = "Staff ID")]
        public int? StaffID { get; set; }
        public virtual Staff? Staff { get; set; }

        
    }
}
