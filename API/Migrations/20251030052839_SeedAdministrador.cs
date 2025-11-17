using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace minimal_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdministrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_administradores",
                table: "administradores");

            migrationBuilder.RenameTable(
                name: "administradores",
                newName: "Administradores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administradores",
                table: "Administradores",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Administradores",
                columns: new[] { "Id", "Email", "Perfil", "Senha" },
                values: new object[] { 1, "administrador@teste.com", "Adm", "123456" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Administradores",
                table: "Administradores");

            migrationBuilder.DeleteData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Administradores",
                newName: "administradores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_administradores",
                table: "administradores",
                column: "Id");
        }
    }
}
