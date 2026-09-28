using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updated_config_for_account_from_fluentvalidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop existing column
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Accounts");

            // Add new column with integer type
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop existing column
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Accounts");
            
            // Add new column with string type
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Asset");
        }
    }
}
