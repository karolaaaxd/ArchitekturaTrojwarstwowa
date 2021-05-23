using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_CoreWebApplicationPage.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recenzja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                        
                    RecenzjaUzytkownika = table.Column<string>(nullable: true),
                    Nick = table.Column<string>(nullable: true),
                    Ocena = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzja", x => x.Id);
                });
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recenzja");
           
        }


        





    }
}
