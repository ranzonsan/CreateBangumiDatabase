using Microsoft.EntityFrameworkCore.Migrations;
using BangumiArchiveTool;

#nullable disable

namespace BangumiArchiveTool
{
    /// <inheritdoc />
    public partial class AddPositionKeyToSubjectPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectPerson",
                table: "SubjectPerson");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectPerson",
                table: "SubjectPerson",
                columns: new[] { "Subject_Id", "Person_Id", "Position" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectPerson",
                table: "SubjectPerson");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectPerson",
                table: "SubjectPerson",
                columns: new[] { "Subject_Id", "Person_Id" });
        }
    }
}
