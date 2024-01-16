using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Shared.Domain
{
    public class Prescription
    {
        public int PrescriptionID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? IssueDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ExpiryDate { get; set; }

        public int OnlineConsultationID { get; set; }

        public virtual OnlineConsultation? OnlineConsultation { get; set; }
    }
}