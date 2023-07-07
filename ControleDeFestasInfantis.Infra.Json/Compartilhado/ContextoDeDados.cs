using System.Text.Json;
using System.Text.Json.Serialization;
using ControleDeFestasInfantis.Dominio.ModuloCliente;
using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using ControleDeFestasInfantis.Dominio.ModuloItem;
using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.Infra.Json.Compartilhado
{
    public class ContextoDeDados
    {
        private const string NOME_ARQUIVO = "Compartilhado//FestasInfantis.json";

        public List<Cliente> clientes { get; set; }
        public List<Aluguel> alugueis { get; set; }
        public List<Item> itens { get; set; }
        public List<Tema> temas { get; set; }

        public ContextoDeDados()
        {
            clientes = new List<Cliente>();
            alugueis = new List<Aluguel>();
            itens = new List<Item>();
            temas = new List<Tema>();
        }

        public ContextoDeDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            if (!File.Exists(NOME_ARQUIVO))


            File.WriteAllText(NOME_ARQUIVO, JsonSerializer.Serialize(this, ObterConfiguracoes()));
        }

        private void CarregarDoArquivoJson()
        {
            if (File.Exists(NOME_ARQUIVO) && File.ReadAllText(NOME_ARQUIVO).Length > 0)
            {
                ContextoDeDados ctx = JsonSerializer.Deserialize<ContextoDeDados>(File.ReadAllText(NOME_ARQUIVO), ObterConfiguracoes());

                clientes = ctx.clientes;
                alugueis = ctx.alugueis;
                itens = ctx.itens;
                temas = ctx.temas;
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
