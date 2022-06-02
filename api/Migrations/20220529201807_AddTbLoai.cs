using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddTbLoai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDLoai",
                table: "HangHoa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    IDLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.IDLoai);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HangHoa_IDLoai",
                table: "HangHoa",
                column: "IDLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_HangHoa_Loai_IDLoai",
                table: "HangHoa",
                column: "IDLoai",
                principalTable: "Loai",
                principalColumn: "IDLoai",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HangHoa_Loai_IDLoai",
                table: "HangHoa");

            migrationBuilder.DropTable(
                name: "Loai");

            migrationBuilder.DropIndex(
                name: "IX_HangHoa_IDLoai",
                table: "HangHoa");

            migrationBuilder.DropColumn(
                name: "IDLoai",
                table: "HangHoa");
        }
    }
}
