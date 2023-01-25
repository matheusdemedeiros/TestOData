using Microsoft.EntityFrameworkCore.Migrations;

namespace TestOData.Migrations
{
    public partial class PopulaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //escolas
            migrationBuilder.Sql("Insert Into Escolas(nome, estado, cidade) Values('Escola Técnica Federal','SP','Campinas')");
            migrationBuilder.Sql("Insert Into Escolas(nome, estado, cidade) Values('Escola Industrial Paulista','SP','Piracicaba')");
            migrationBuilder.Sql("Insert Into Escolas(nome, estado, cidade) Values('Instituto Sobral Filho','SP','Sorocaba')");
            migrationBuilder.Sql("Insert Into Escolas(nome, estado, cidade) Values('Instituto Getulio Vargas','MG','Itajuba')");
            migrationBuilder.Sql("Insert Into Escolas(nome, estado, cidade) Values('Escola Técnica de Santos','SP','Santos')");

            //alunos
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Pedro Escobar',8,1)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Marina Silva',7,1)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Ricardo Rocha',6,5)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Amanda Lima',9,1)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('José Santos',5,2)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('José Bueno Silva',7,2)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Antônio Sanches',6,3)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Marisa Ribeiro',8,3)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Bianca Lima Sá',9,4)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Jessica Silva',6,4)");
            migrationBuilder.Sql("Insert Into Alunos(nome, nota, escolaid) Values('Jefferson Rodrigues',7,5)");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //alunos
            migrationBuilder.Sql("Delete From Escolas");
            //escolas
            migrationBuilder.Sql("Delete from Alunos");
        }
    }
}
