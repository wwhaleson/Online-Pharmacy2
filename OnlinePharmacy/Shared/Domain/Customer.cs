using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Customer
    {
        [Required(ErrorMessage = "Customer ID is required")]
        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements")]
        public string CustFname { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string CustLname { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Gender should only contain alphabetic characters")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Choose the appropriate Gender")]
        public string CustGender { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [DataType(DataType.PostalCode)]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Postal Code is not in a valid format")]
        public int? CustPostalCode { get; set; }

        [Required(ErrorMessage = "Block Number is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Block Number should be a valid number")]
        public int? CustBlockNo { get; set; }

        [Required(ErrorMessage = "Floor Number is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Floor Number should be a valid number")]
        public int? CustFloorNo { get; set; }

        [Required(ErrorMessage = "Unit Number is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Unit Number should be a valid number")]
        public int? CustUnitNo { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Address does not meet length requirements")]
        public string CustAddress { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
        public int CustPhoneNo { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email")]
        [EmailAddress]
        public string CustEmail { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Password does not meet the complexity requirements")]
        public string CustPass { get; set; }

        /*
        public virtual List<OnlineConsultation>? OnlineConsultations { get; set; }
        public virtual List<Order>? Orders { get; set; }*/
    }
}