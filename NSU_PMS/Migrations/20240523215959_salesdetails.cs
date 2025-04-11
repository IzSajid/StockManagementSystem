using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NSU_PMS.Migrations
{
    /// <inheritdoc />
    public partial class salesdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountStrategy",
                table: "SalesDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiscountStrategy",
                table: "SalesDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
