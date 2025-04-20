using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateBangumiDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddSubject_IdKeyToPersonCharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonCharacter",
                table: "PersonCharacter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonCharacter",
                table: "PersonCharacter",
                columns: new[] { "Person_Id", "Subject_Id", "Character_Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonCharacter",
                table: "PersonCharacter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonCharacter",
                table: "PersonCharacter",
                columns: new[] { "Person_Id", "Character_Id" });
        }
    }
}
