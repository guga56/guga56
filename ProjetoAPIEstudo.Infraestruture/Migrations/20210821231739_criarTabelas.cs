using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAPIEstudo.Infraestruture.Migrations
{
    public partial class criarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Residencial = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    Id_Cliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "tb_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Veiculo",
                columns: table => new
                {
                    IdVeiculo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeVeiculo = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true),
                    Id_Cliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Veiculo", x => x.IdVeiculo);
                    table.ForeignKey(
                        name: "FK_tb_Veiculo_tb_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "tb_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Requerente",
                columns: table => new
                {
                    IdRequerente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeRequerente = table.Column<string>(nullable: true),
                    EmailRequerente = table.Column<string>(nullable: true),
                    Id_Veiculo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Requerente", x => x.IdRequerente);
                    table.ForeignKey(
                        name: "FK_tb_Requerente_tb_Veiculo_Id_Veiculo",
                        column: x => x.Id_Veiculo,
                        principalTable: "tb_Veiculo",
                        principalColumn: "IdVeiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Cliente",
                table: "tb_Endereco",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Requerente_Id_Veiculo",
                table: "tb_Requerente",
                column: "Id_Veiculo");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Veiculo_Id_Cliente",
                table: "tb_Veiculo",
                column: "Id_Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Requerente");

            migrationBuilder.DropTable(
                name: "tb_Veiculo");

            migrationBuilder.DropTable(
                name: "tb_Cliente");
        }
    }
}
