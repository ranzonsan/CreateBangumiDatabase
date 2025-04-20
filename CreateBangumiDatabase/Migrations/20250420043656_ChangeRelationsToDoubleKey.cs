using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateBangumiDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRelationsToDoubleKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation",
                columns: new[] { "Subject_Id", "Related_Subject_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectPerson",
                table: "SubjectPerson",
                columns: new[] { "Subject_Id", "Person_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectCharacter",
                table: "SubjectCharacter",
                columns: new[] { "Character_Id", "Subject_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonCharacter",
                table: "PersonCharacter",
                columns: new[] { "Person_Id", "Character_Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectPerson",
                table: "SubjectPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectCharacter",
                table: "SubjectCharacter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonCharacter",
                table: "PersonCharacter");
        }
    }
}
