using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoPrdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Coca-Cola Diet', 'Refrigerante de Cola 350ml', 5.45, 'coca-cola.jpg', GETDATE(), 1)");
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Pepsi', 'Refrigerante de Cola 350ml', 4.99, 'pepsi.jpg', GETDATE(), 1 )");
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Guaraná Antarctica', 'Refrigerante de Guaraná 350ml', 4.75, 'guarana.jpg', GETDATE(), 1)");
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Bolo de Chocolate', 'Delicioso bolo de chocolate', 15.99, 'bolo-chocolate.jpg', GETDATE(), 2)");
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Sorvete de Morango', 'Sorvete sabor morango', 6.75, 'sorvete-morango.jpg', GETDATE(), 2)");
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Cheesecake', 'Clássico com calda de frutas vermelhas', 12.50, 'cheesecake.jpg', GETDATE(), 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
