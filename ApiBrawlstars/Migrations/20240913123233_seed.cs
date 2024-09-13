using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBrawlstars.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brawlstars",
                columns: new[] { "Id", "Ano", "Foto", "Lane", "Nome", "Raridade", "Regiao", "Status", "Tipo" },
                values: new object[] { 1, 2018, "https://liquipedia.net/commons/images/f/f6/Brawl_Shelly.png", "Lateral", "Shelly", "Inicial", "Velho Oeste", "Ativo", "Destruidor" });

            migrationBuilder.InsertData(
                table: "Brawlstars",
                columns: new[] { "Id", "Ano", "Foto", "Lane", "Nome", "Raridade", "Regiao", "Status", "Tipo" },
                values: new object[] { 2, 2018, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXTwLLQ1N2m6Li9bMtYmChaymQx1qZUtu2-A&s", "Lateral", "Nita", "Raro", "Tribo Shaman", "Ativo", "Destruidor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brawlstars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brawlstars",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
