using Microsoft.EntityFrameworkCore.Migrations;
using BangumiArchiveTool;

#nullable disable

namespace BangumiArchiveTool
{
    /// <inheritdoc />
    public partial class AddRelation_TypeKeyToSubjectRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation",
                columns: new[] { "Subject_Id", "Relation_Type", "Related_Subject_Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation",
                columns: new[] { "Subject_Id", "Related_Subject_Id" });
        }
    }
}
