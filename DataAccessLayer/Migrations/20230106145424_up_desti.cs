using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class up_desti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Destionations_DestinationID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destionations_DestinationID",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Destionations",
                table: "Destionations");

            migrationBuilder.RenameTable(
                name: "Destionations",
                newName: "Destinations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destinations",
                table: "Destinations",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Destinations_DestinationID",
                table: "Comments",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_DestinationID",
                table: "Reservations",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Destinations_DestinationID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_DestinationID",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Destinations",
                table: "Destinations");

            migrationBuilder.RenameTable(
                name: "Destinations",
                newName: "Destionations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destionations",
                table: "Destionations",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Destionations_DestinationID",
                table: "Comments",
                column: "DestinationID",
                principalTable: "Destionations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destionations_DestinationID",
                table: "Reservations",
                column: "DestinationID",
                principalTable: "Destionations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
