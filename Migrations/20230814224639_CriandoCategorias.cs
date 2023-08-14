﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class CriandoCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Categorias (Nome, ImagemUrl) Values ('Bebidas', 'bebidas.jpg') ");
            mb.Sql("insert into Categorias (Nome, ImagemUrl) Values ('Lanches', 'lanches.jpg') ");
            mb.Sql("insert into Categorias (Nome, ImagemUrl) Values ('Sobremesas', 'sobremesas.jpg') ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
