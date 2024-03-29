﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Staff
    {
        //? Nullable
        [Required(ErrorMessage = "Staff ID is required")]
        [Display(Name = "Staff ID")]
        public int StaffID { get; set; }

        [Display(Name = "Staff Image")]
        [RegularExpression(@"\b(?:https?|ftp):\/\/\S+\.(png|jpg|jpeg|gif|bmp)\b", ErrorMessage = "Invalid image URL or file path")]
        public string? StaffImage { get; set; }


        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements")]
        public string StaffFname { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string StaffLname { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Gender should only contain alphabetic characters")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Choose the appropriate Gender")]
        public string StaffGender { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "The Staff Email field is not a valid email address")]
        public string Staff_email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Password does not meet the complexity requirements")]
        public string Staff_pass { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Position should only contain alphabetic characters")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Choose the appropriate Position")]
        [Display(Name = "Position")]
        public string Position { get; set; }
    }
}