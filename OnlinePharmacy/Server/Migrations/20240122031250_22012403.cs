using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlinePharmacy.Server.Migrations
{
    /// <inheritdoc />
    public partial class _22012403 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ea140d2-c569-4f21-8829-3f9b8315837d", "AQAAAAIAAYagAAAAEJqjozeYnQd6DeHhfzAxFSlodqEwzlc92lMPBzcRCoIAEHC/+KMTvdyxkermo/s3aA==", "213b51d5-9ed5-4b42-9792-8254ca025059" });

            migrationBuilder.UpdateData(
                table: "Delivery",
                keyColumn: "DeliveryID",
                keyValue: 1,
                columns: new[] { "EstimatedDeliveryDate", "EstimatedDeliveryTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Delivery",
                keyColumn: "DeliveryID",
                keyValue: 2,
                columns: new[] { "EstimatedDeliveryDate", "EstimatedDeliveryTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(360), new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "OnlineConsultation",
                keyColumn: "OnlineConsultationID",
                keyValue: 1,
                columns: new[] { "ConsultationDateEnd", "ConsultationDateStart", "ConsultationTimeEnd", "ConsultationTimeStart" },
                values: new object[] { new DateTime(2024, 1, 22, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(545), new DateTime(2024, 1, 22, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(545), new DateTime(2024, 1, 22, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(544), new DateTime(2024, 1, 22, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "OnlineConsultation",
                keyColumn: "OnlineConsultationID",
                keyValue: 2,
                columns: new[] { "ConsultationDateEnd", "ConsultationDateStart", "ConsultationTimeEnd", "ConsultationTimeStart" },
                values: new object[] { new DateTime(2024, 1, 22, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 1, 22, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(552), new DateTime(2024, 1, 22, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(552), new DateTime(2024, 1, 22, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "OrderDate", "OrderTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "OrderDate", "OrderTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(943), new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "PrescriptionID",
                keyValue: 2,
                column: "IssueDate",
                value: new DateTime(2024, 1, 22, 11, 12, 49, 883, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 12, 49, 883, DateTimeKind.Utc).AddTicks(1546));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "520204d3-d906-4852-86c7-f241ea199fc2", "AQAAAAIAAYagAAAAEBIiJUwV2sXQSWuqhmAITA11ukm1mQ1KbTgkvJeUOAgs7qUPiYceel75tWQw7HS1cA==", "7d189eba-ea59-4dbf-93aa-bbb79bbc2633" });

            migrationBuilder.UpdateData(
                table: "Delivery",
                keyColumn: "DeliveryID",
                keyValue: 1,
                columns: new[] { "EstimatedDeliveryDate", "EstimatedDeliveryTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(3481), new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Delivery",
                keyColumn: "DeliveryID",
                keyValue: 2,
                columns: new[] { "EstimatedDeliveryDate", "EstimatedDeliveryTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(3497), new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "OnlineConsultation",
                keyColumn: "OnlineConsultationID",
                keyValue: 1,
                columns: new[] { "ConsultationDateEnd", "ConsultationDateStart", "ConsultationTimeEnd", "ConsultationTimeStart" },
                values: new object[] { new DateTime(2024, 1, 22, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(3716), new DateTime(2024, 1, 22, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(3716), new DateTime(2024, 1, 22, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(3715), new DateTime(2024, 1, 22, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "OnlineConsultation",
                keyColumn: "OnlineConsultationID",
                keyValue: 2,
                columns: new[] { "ConsultationDateEnd", "ConsultationDateStart", "ConsultationTimeEnd", "ConsultationTimeStart" },
                values: new object[] { new DateTime(2024, 1, 22, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(3726), new DateTime(2024, 1, 22, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(3725), new DateTime(2024, 1, 22, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(3725), new DateTime(2024, 1, 22, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "OrderDate", "OrderTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "OrderDate", "OrderTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(4094), new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "PrescriptionID",
                keyValue: 2,
                column: "IssueDate",
                value: new DateTime(2024, 1, 22, 11, 3, 45, 253, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "ProductExpiryDate",
                value: new DateTime(2024, 1, 23, 3, 3, 45, 253, DateTimeKind.Utc).AddTicks(4679));
        }
    }
}
