using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignPattern.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerBalance", "CustomerName" },
                values: new object[,]
                {
                    { 1, 28000m, "Ali Çınar" },
                    { 2, 32000m, "Zeynep Pınar" },
                    { 3, 38000m, "Mete Öztürk" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);
        }
    }
}
