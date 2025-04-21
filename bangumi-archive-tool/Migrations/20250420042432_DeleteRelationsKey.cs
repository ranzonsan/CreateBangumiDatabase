using Microsoft.EntityFrameworkCore.Migrations;
using BangumiArchiveTool;

#nullable disable

namespace BangumiArchiveTool
{
    /// <inheritdoc />
    public partial class DeleteRelationsKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Subject_Id",
                table: "SubjectRelation",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Person_Id",
                table: "SubjectPerson",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Character_Id",
                table: "SubjectCharacter",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Person_Id",
                table: "PersonCharacter",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Subject_Id",
                table: "SubjectRelation",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Person_Id",
                table: "SubjectPerson",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Character_Id",
                table: "SubjectCharacter",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Person_Id",
                table: "PersonCharacter",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation",
                column: "Subject_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectPerson",
                table: "SubjectPerson",
                column: "Person_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectCharacter",
                table: "SubjectCharacter",
                column: "Character_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonCharacter",
                table: "PersonCharacter",
                column: "Person_Id");
        }
    }
}
