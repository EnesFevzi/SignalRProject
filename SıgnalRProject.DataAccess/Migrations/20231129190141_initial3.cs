using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SıgnalRProject.DataAccess.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(219), "Vegan ve et içermeyen bir lezzet deneyimi", "/images/burger-images/vegan-beyond-burger.jpg", 19.50m, "Vegan Beyond Burger" });

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
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 1, 40, 452, DateTimeKind.Local).AddTicks(216), "Bacon ve avokado ile zenginleştirilmiş burger", "/images/burger-images/bacon-avocado-burger.jpg", 23.50m, "Bacon Avocado Burger" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75b050e7-9f43-44ab-8d62-ddf7382850a5", "AQAAAAEAACcQAAAAEP7NzWu8vFiWNZx9tZGlBnIZEaRQWTnYJ6z+Qs25WJlvcR1VFiZFqrzDMh7X+EoQ7g==", "e834721d-db7e-4db6-a02d-1697a9e8e80a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6896), "Bacon ve avokado ile zenginleştirilmiş burger", "/images/burger-images/bacon-avocado-burger.jpg", 23.50m, "Bacon Avocado Burger" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6900), "Vegan ve et içermeyen bir lezzet deneyimi", "/images/burger-images/vegan-beyond-burger.jpg", 19.50m, "Vegan Beyond Burger" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7209));
        }
    }
}
