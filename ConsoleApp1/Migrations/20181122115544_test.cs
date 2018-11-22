using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class test : Migration
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
                    MaskChar = table.Column<string>(nullable: true),
                    MaskInvalidMessage = table.Column<string>(nullable: true),
                    Mode = table.Column<int>(nullable: true),
                    Placeholder = table.Column<string>(nullable: true),
                    ShowClearButton = table.Column<bool>(nullable: true),
                    ShowMaskMode = table.Column<int>(nullable: true),
                    Spellcheck = table.Column<bool>(nullable: true),
                    Format = table.Column<string>(nullable: true),
                    InvalidValueMessage = table.Column<string>(nullable: true),
                    Min = table.Column<double>(nullable: true),
                    Max = table.Column<double>(nullable: true),
                    ShowSpinButtons = table.Column<bool>(nullable: true),
                    Step = table.Column<double>(nullable: true),
                    UseLargeSpinButtons = table.Column<bool>(nullable: true),
                    EditorOptionsTextArea_Mask = table.Column<string>(nullable: true),
                    EditorOptionsTextArea_MaskChar = table.Column<string>(nullable: true),
                    EditorOptionsTextArea_MaskInvalidMessage = table.Column<string>(nullable: true),
                    EditorOptionsTextArea_Mode = table.Column<int>(nullable: true),
                    EditorOptionsTextArea_Placeholder = table.Column<string>(nullable: true),
                    EditorOptionsTextArea_ShowClearButton = table.Column<bool>(nullable: true),
                    EditorOptionsTextArea_ShowMaskMode = table.Column<int>(nullable: true),
                    EditorOptionsTextArea_Spellcheck = table.Column<bool>(nullable: true),
                    MaxLength = table.Column<int>(nullable: true),
                    AutoResizeEnabled = table.Column<bool>(nullable: true),
                    MaxHeight = table.Column<double>(nullable: true),
                    MinHeight = table.Column<double>(nullable: true),
                    EditorOptionsTextBox_Mask = table.Column<string>(nullable: true),
                    EditorOptionsTextBox_MaskChar = table.Column<string>(nullable: true),
                    EditorOptionsTextBox_MaskInvalidMessage = table.Column<string>(nullable: true),
                    EditorOptionsTextBox_Mode = table.Column<int>(nullable: true),
                    EditorOptionsTextBox_Placeholder = table.Column<string>(nullable: true),
                    EditorOptionsTextBox_ShowClearButton = table.Column<bool>(nullable: true),
                    EditorOptionsTextBox_ShowMaskMode = table.Column<int>(nullable: true),
                    EditorOptionsTextBox_Spellcheck = table.Column<bool>(nullable: true)
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
