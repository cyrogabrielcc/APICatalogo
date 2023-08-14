using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoPrdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Coca-Cola Diet', 'Refrigerante de Cola 350ml', 5.45, 'coca-cola.jpg', 35, GETDATE(), 1)");
            migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Pepsi', 'Refrigerante de Cola 350ml', 4.99, 'pepsi.jpg', 35, GETDATE(), 1 )");
            migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Guaraná Antarctica', 'Refrigerante de Guaraná 350ml', 4.75, 'guarana.jpg', 35, GETDATE(), 1)");
            migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Bolo de Chocolate', 'Delicioso bolo de chocolate', 15.99, 'bolo-chocolate.jpg', 35, GETDATE(), 2)");
            migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Sorvete de Morango', 'Sorvete sabor morango', 6.75, 'sorvete-morango.jpg', 35, GETDATE(), 2)");
            migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Cheesecake', 'Clássico cheesecake com calda de frutas vermelhas', 12.50, 'cheesecake.jpg', 35, GETDATE(), 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
