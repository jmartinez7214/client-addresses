using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clients_addresses.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientAddresses_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Samuel", "Polanco" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Juan", "Perez" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 3, "Francisco", "Rivera" });

            migrationBuilder.InsertData(
                table: "ClientAddresses",
                columns: new[] { "Id", "Address", "ClientId" },
                values: new object[,]
                {
                    { 1, "558 Henry Smith St., Southfield, MI 48076", 1 },
                    { 2, "174 Prince Street, Hickory, NC 28601", 1 },
                    { 3, "58 River St., Findlay, OH 45840", 2 },
                    { 4, "7387 Myers Ave., Saint Joseph, MI 49085", 2 },
                    { 5, "8228 Philmont Ave., Marshalltown, IA 50158", 2 },
                    { 6, "7531 Thompson Drive, New York, NY 10002", 2 },
                    { 7, "60 Dogwood Street, Vicksburg, MS 39180", 3 },
                    { 8, "13 Alton St., South Richmond Hill, NY 11419", 3 },
                    { 9, "7626 E. Armstrong Lane, Dickson, TN 37055", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientAddresses_ClientId",
                table: "ClientAddresses",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientAddresses");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
