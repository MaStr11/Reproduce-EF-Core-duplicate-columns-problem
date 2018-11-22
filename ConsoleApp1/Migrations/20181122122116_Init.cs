using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EditorOptionsBase",
                columns: table => new
                {
                    EditorType = table.Column<int>(nullable: false),
                    ReadOnly = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mask = table.Column<string>(nullable: true),
                    Format = table.Column<string>(nullable: true),
                    EditorOptionsTextArea_Mask = table.Column<string>(nullable: true),
                    MaxLength = table.Column<int>(nullable: true),
                    EditorOptionsTextBox_Mask = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditorOptionsBase", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditorOptionsBase");
        }
    }
}
