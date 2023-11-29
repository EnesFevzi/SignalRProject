using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SıgnalRProject.DataAccess.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Discounts");

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

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "DiscountID", "Amount", "Description", "ImageUrl", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "20", "Açılışa Özel İndirim", "/images/discount-images/yüzde20.png", true, "İlk İndirim" },
                    { 2, "10", "Öğrenci Kartınızı yetkiliye gösterin %10 indirim kazanın.", "/images/discount-images/yüzde10.png", true, "Öğrenciye Özel İndirim" }
                });

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 1,
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 6,
                column: "Status",
                value: false);

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 10,
                column: "Status",
                value: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountID",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Discounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Discounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Discounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Discounts",
                type: "datetime2",
                nullable: true);

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
                keyValue: 1,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 6,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "MenuTables",
                keyColumn: "MenuTableID",
                keyValue: 10,
                column: "Status",
                value: true);

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
    }
}
