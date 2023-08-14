using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoProdutosLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Batata Frita', 'Porção de batata frita crocante', '5.25', 'batata-frita.jpg', 35, GETDATE(), 3 )" );
            migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Sanduíche de Frango', 'Sanduíche de frango grelhado com alface e maionese', '8.75', 'sanduiche-frango.jpg', 35, GETDATE(), 3 )");
            migrationBuilder.Sql("Insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Salada Caesar', 'Salada fresca com alface, frango e molho Caesar', '7.99', 'salada-caesar.jpg', 35, GETDATE(), 3 )");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
