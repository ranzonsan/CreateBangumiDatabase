using Microsoft.EntityFrameworkCore.Migrations;
using BangumiArchiveTool;

#nullable disable

namespace BangumiArchiveTool
{
    /// <inheritdoc />
    public partial class AddRelationIdToSubjectRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation");

            migrationBuilder.AddColumn<int>(
                name: "RelationId",
                table: "SubjectRelation",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation",
                column: "RelationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation");

            migrationBuilder.DropColumn(
                name: "RelationId",
                table: "SubjectRelation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectRelation",
                table: "SubjectRelation",
                columns: new[] { "Subject_Id", "Relation_Type", "Related_Subject_Id", "Order" });
        }
    }
}
