using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SıgnalRProject.DataAccess.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "FooterDescription", "FooterTitle", "Location", "Mail", "OpenDays", "OpenDaysDescription", "OpenHours", "Phone" },
                values: new object[] { 1, "Kaliteli ve lezzetli yemekleriyle müşterilerimize hizmet veriyoruz.", "Lezzetin Adresi", "İstanbul, Türkiye", "info@example.com", "Pazartesi - Cumartesi", "Haftanın 6 günü açığız.", "10:00 - 22:00", "+90 123 456 7890" });

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
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6896));

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
                column: "CreatedDate",
                value: new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(6900));

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

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "SocialMediaID", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Icon", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "Url" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7137), null, null, "fa fa-github", false, null, null, "GitHub", "https://github.com/EnesFevzi" },
                    { 2, null, new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7142), null, null, "fa fa-linkedin", false, null, null, "LinkedIn", "www.linkedin.com/in/enes-fevzi-cicekli\r\n\r\n" },
                    { 3, null, new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7143), null, null, "fa fa-briefcase", false, null, null, "Portföy Sitesi", "https://enesfevzicicekli.com.tr/" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "TestimonialID", "Comment", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "Yemekleri ve hizmeti çok seviyorum! Kesinlikle tavsiye ederim.", null, new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7206), null, null, "/images/60111.jpg", false, null, null, "Tarık Yüksel", "Memnun Müşteri" },
                    { 2, "Arkadaşlarınızla vakit geçirmek için harika bir yer. Lezzetli burgerler!", null, new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7208), null, null, "/images/60111.jpg", false, null, null, "Tekin Öztürk", "Düzenli Müşteri" },
                    { 3, "Mükemmel müşteri hizmeti. Kesinlikle tekrar ziyaret edeceğim.", null, new DateTime(2023, 11, 29, 21, 57, 52, 125, DateTimeKind.Local).AddTicks(7209), null, null, "/images/60111.jpg", false, null, null, "Eren Yaman", "Memnun Müşteri" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMediaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed852fbc-e277-4a7b-9e72-fbd4a7bdfdfe", "AQAAAAEAACcQAAAAEHJIKYY39kxS9Pf+f8mTyKaY3tow4z3GKiGFrifd49OoDwHwPvVC75oZMvNYHtByvg==", "6340eebe-5b53-4f1a-99a5-e3fc42f42034" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 28, 22, 21, 46, 513, DateTimeKind.Local).AddTicks(1520));
        }
    }
}
