using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Infrastructure.Migrations
{
    public partial class MySql_101_CarouselItem_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarouselItem",
                columns: new[] { "ID", "ImageAlt", "ImageSrc" },
                values: new object[] { 1, "First slide", "/img/carousel/how-to-become-an-information-technology-specialist160684886950141.jpg" });

            migrationBuilder.InsertData(
                table: "CarouselItem",
                columns: new[] { "ID", "ImageAlt", "ImageSrc" },
                values: new object[] { 2, "Second slide", "/img/carousel/Information-Technology-1-1024x462.jpg" });

            migrationBuilder.InsertData(
                table: "CarouselItem",
                columns: new[] { "ID", "ImageAlt", "ImageSrc" },
                values: new object[] { 3, "Third slide", "/img/carousel/Information-Technology.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarouselItem",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarouselItem",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarouselItem",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
