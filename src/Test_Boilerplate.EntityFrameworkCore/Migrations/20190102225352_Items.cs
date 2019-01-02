using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Boilerplate.Migrations
{
    public partial class Items : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Person",
                newName: "PersonId");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonName = table.Column<string>(nullable: true),
                    PersonId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_PersonId",
                table: "Item",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Person",
                newName: "PersonID");
        }
    }
}
