using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductServices.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pbarcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pcolor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pdescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pimage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PQTY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
