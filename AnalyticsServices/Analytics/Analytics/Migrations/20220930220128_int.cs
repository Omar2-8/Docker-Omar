using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Analytics.Migrations
{
    public partial class @int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Analytics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    max = table.Column<int>(type: "int", nullable: false),
                    min = table.Column<int>(type: "int", nullable: false),
                    avg = table.Column<int>(type: "int", nullable: false),
                    sum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analytics");
        }
    }
}
