using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SıgnalRProject.DataAccess.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b2ddffb-d250-47b3-bba3-1e10d07ab758", "AQAAAAEAACcQAAAAEPJT31YWHzvWukZ+EsnUwqRNlywKq380psE3pzH1l4KVP8is4lt4Jhc2FdYPPCMzhA==", "ab6f58fa-80e0-4aa2-991c-fa1b4eef7e43" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 2,
                column: "Name",
                value: "Bahçe-02");

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 3,
                column: "Name",
                value: "Bahçe-03");

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 4,
                column: "Name",
                value: "Bahçe-04");

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 5,
                column: "Name",
                value: "Teras-01");

            migrationBuilder.InsertData(
                table: "MenuTables",
                columns: new[] { "MenuTableID", "Name", "Status" },
                values: new object[,]
                {
                    { 6, "Teras-02", true },
                    { 7, "Teras-03", true },
                    { 8, "Teras-04", true },
                    { 9, "Salon-01", true },
                    { 10, "Salon-02", true },
                    { 11, "Salon-03", true },
                    { 12, "Salon-04", true }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 41, 57, 540, DateTimeKind.Local).AddTicks(8698));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "246192f5-f442-494a-bc6b-b0b9b73462b7", "AQAAAAEAACcQAAAAEKjJk462+OjOWPrqF85f+/DIqx8KwpJ80WiaAAHrFVHJH5p/Lily6vrQ1r+D7232+A==", "06b9959d-a6d5-40e1-afe4-35e00735f827" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 2,
                column: "Name",
                value: "Teras-01");

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 3,
                column: "Name",
                value: "Salon-01");

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 4,
                column: "Name",
                value: "Bahçe-02");

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 5,
                column: "Name",
                value: "Teras-02");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 36, 25, 647, DateTimeKind.Local).AddTicks(874));
        }
    }
}
