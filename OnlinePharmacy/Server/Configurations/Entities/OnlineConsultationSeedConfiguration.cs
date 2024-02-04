using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy.Shared.Domain;
using System;

namespace OnlinePharmacy.Server.Configurations.Entities
{
    public class OnlineConsultationSeedConfiguration : IEntityTypeConfiguration<OnlineConsultation>
    {
        public void Configure(EntityTypeBuilder<OnlineConsultation> builder)
        {
            builder.HasData(
                new OnlineConsultation
                {
                    OnlineConsultationID = 1,
                    ConsultationTimeStart = DateTime.UtcNow, // Use UtcNow for a standardized time
                    ConsultationTimeEnd = DateTime.UtcNow,
                    ConsultationDateStart = DateTime.UtcNow,
                    ConsultationDateEnd = DateTime.UtcNow,
                    ConsultationPrice = 40, // Use decimal value
                    ConsultationSymptom = "Fever, Headache",
                    ConsultationDiagnosis = "Common cold",
                    ConsultationStatus = "Completed",
                    ConsultationPlatform = "Online Call",
                    CustomerID = 1,
                    PharmacistID = 1
                },
                new OnlineConsultation
                {
                    OnlineConsultationID = 2,
                    ConsultationTimeStart = DateTime.UtcNow,
                    ConsultationTimeEnd = DateTime.UtcNow,
                    ConsultationDateStart = DateTime.UtcNow,
                    ConsultationDateEnd = DateTime.UtcNow,
                    ConsultationPrice = 45.75m,
                    ConsultationSymptom = "Headache",
                    ConsultationDiagnosis = "Common cold",
                    ConsultationStatus = "Completed",
                    ConsultationPlatform = "Online Call",
                    CustomerID = 2,
                    PharmacistID = 1
                }
            );
        }
    }
}
