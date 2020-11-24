using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseLayer.Migrations
{
    public partial class addingLongituteLatitudeToDestionation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Friend",
                table: "Friend");

            migrationBuilder.AddColumn<decimal>(
                name: "Latitude",
                table: "Destination",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Longitude",
                table: "Destination",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friend",
                table: "Friend",
                column: "FriendshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Friend_FriendOfId",
                table: "Friend",
                column: "FriendOfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Friend",
                table: "Friend");

            migrationBuilder.DropIndex(
                name: "IX_Friend_FriendOfId",
                table: "Friend");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Destination");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friend",
                table: "Friend",
                columns: new[] { "FriendOfId", "FriendWithId" });
        }
    }
}
