using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SıgnalRProject.DataAccess.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "MenuTables",
                columns: new[] { "MenuTableID", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Bahçe-01", true },
                    { 2, "Teras-01", true },
                    { 3, "Salon-01", true },
                    { 4, "Bahçe-02", true },
                    { 5, "Teras-02", true }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d26d710-1726-41be-90da-540fe3934417", "AQAAAAEAACcQAAAAENya/2YC0kKxTmBwhUBGvUtbW3Z1zLcvV2QRUYeg2tnzQNCyYvQPhoTSahrIPxZlIw==", "32961f2b-5a31-498e-8691-a579481ec285" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 451, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 451, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 451, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 451, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 451, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(440));
        }
    }
}
