﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NoteKeeper.Dominio.ModuloCategoria;
using NoteKeeper.Dominio.ModuloNota;
using NoteKeeper.Infra.Orm.Compartilhado;
using NoteKeeper.Infra.Orm.ModuloCategoria;
using NoteKeeper.Infra.Orm.ModuloNota;

namespace NoteKeeper.ConsoleApp;
public class Program
{
    static void Main(string[] args)
    {

        var novaCategoria = new Categoria();
        novaCategoria.Titulo = "Mercado";

        var optionsBuilder = new DbContextOptionsBuilder<NoteKeeperDbContext>();

        IConfiguration configuracao = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        var ConnectionString = configuracao.GetConnectionString("SqlServer");

        optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=NoteKeeper;Integrated Security=True");

        var dbContext = new NoteKeeperDbContext(optionsBuilder.Options);

        var repositorioCategoria = new RepositorioCategoriaOrm(dbContext);
        repositorioCategoria.InserirAsync(novaCategoria);

        var novaNota = new Nota();
        novaNota.Titulo = "lista da semana";
        novaNota.Conteudo = "Leite Pão Carne";
        novaNota.Arquivada = false;
        novaNota.Tema = TemaEnum.Basico;
        novaNota.Categoria = novaCategoria;

        var repositorioNota = new RepositorioNotaOrm(dbContext);
        repositorioNota.InserirAsync(novaNota);


        dbContext.SaveChanges();
    }
}