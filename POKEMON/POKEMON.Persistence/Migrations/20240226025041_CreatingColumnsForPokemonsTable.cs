using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POKEMON.Persistence.Migrations
{
    public partial class CreatingColumnsForPokemonsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TypeOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    SpeedAttack = table.Column<int>(type: "int", nullable: false),
                    SpeedDefense = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Generation = table.Column<int>(type: "int", nullable: false),
                    Legendary = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_Name",
                table: "Pokemons",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
