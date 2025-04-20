using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateBangumiDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderKeyToSubjectRelation : Migration
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
                columns: new[] { "Subject_Id", "Relation_Type", "Related_Subject_Id", "Order" });
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
                columns: new[] { "Subject_Id", "Relation_Type", "Related_Subject_Id" });
        }
    }
}
