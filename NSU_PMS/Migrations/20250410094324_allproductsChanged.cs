using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NSU_PMS.Migrations
{
    /// <inheritdoc />
    public partial class allproductsChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoxContent",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StripSize",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoxContent",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StripSize",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
