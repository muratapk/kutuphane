using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Id = table.Column<int>(type: "int", nullable: true),
                    CategoriesCategory_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoriesCategory_Id",
                        column: x => x.CategoriesCategory_Id,
                        principalTable: "Categories",
                        principalColumn: "Category_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesCategory_Id",
                table: "Products",
                column: "CategoriesCategory_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
