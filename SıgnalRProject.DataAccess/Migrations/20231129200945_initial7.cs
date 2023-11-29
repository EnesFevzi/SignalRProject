using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SıgnalRProject.DataAccess.Migrations
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5061a29a-371f-4423-a802-f185cc48645d", "AQAAAAEAACcQAAAAEK8RRT6lrjeOnkes4zKI8JIicfJMQ+e3607dwgyKqO51L1ouc9mU0neFWOxaoAVpeQ==", "8876ac59-981c-4f21-8387-4f2b4f95297a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationID", "Date", "Description", "Icon", "Status", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3858), "İşlem başarıyla tamamlandı.", "fa fa-check", true, "success" },
                    { 2, new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3860), "Uyarı: Dikkatli olun!", "fa fa-exclamation-triangle", true, "warning" },
                    { 3, new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3861), "Hata: İşlem sırasında bir hata oluştu.", "fa fa-times", true, "danger" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 23, 9, 44, 747, DateTimeKind.Local).AddTicks(4185));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8869bece-0b21-4a79-92d1-d4576d820326", "AQAAAAEAACcQAAAAEBsOQLCGTFkie8bMfssC7LN/WyPpimdZa/asUiXd2n6M5innsKq2X010/Ybp/67HLg==", "3ba95ae8-a47e-4775-888e-cfc72705edf8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 49, 57, 266, DateTimeKind.Local).AddTicks(7909));
        }
    }
}
