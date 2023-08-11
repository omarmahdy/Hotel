using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.AddColumn<string>(
                name: "Room_Type",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Room_num",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Room_Type",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "Room_num",
                table: "Guests");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Room_num = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    G_ID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Room_num);
                    table.ForeignKey(
                        name: "FK_Rooms_Guests_G_ID",
                        column: x => x.G_ID,
                        principalTable: "Guests",
                        principalColumn: "G_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_G_ID",
                table: "Rooms",
                column: "G_ID");
        }
    }
}
