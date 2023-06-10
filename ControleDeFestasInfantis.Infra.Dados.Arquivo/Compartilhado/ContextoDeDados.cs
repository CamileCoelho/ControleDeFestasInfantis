using System.Text.Json;
using System.Text.Json.Serialization;
using ControleDeFestasInfantis.Dominio.ModuloTarefa;
using ControleDeFestasInfantis.Dominio.ModuloCompromissos;
using ControleDeFestasInfantis.Dominio.ModuloContato;
using ControleDeFestasInfantis.Dominio.ModuloDespesas;

namespace ControleDeFestasInfantis.Infra.Dados.Arquivo.Compartilhado
{
    public class ContextoDeDados
    {
        private const string NOME_ARQUIVO = "Compartilhado//ControleDeFestasInfantis.json";

        public List<Cliente> clientes { get; set; }
        public List<Festa> festas { get; set; }
        public List<Item> itens { get; set; }
        public List<Tema> temas { get; set; }

        public ContextoDeDados()
        {
            clientes = new List<Cliente>();
            festas = new List<Festa>();
            itens = new List<Item>();
            temas = new List<Tema>();
        }

        public ContextoDeDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            File.WriteAllText(NOME_ARQUIVO, JsonSerializer.Serialize(this, config));
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO) && File.ReadAllText(NOME_ARQUIVO).Length > 0)
            {
                ContextoDeDados ctx = JsonSerializer.Deserialize<ContextoDeDados>(File.ReadAllText(NOME_ARQUIVO), config);

                contatos = ctx.contatos;
                compromissos = ctx.compromissos;
                tarefas = ctx.tarefas;
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new();
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
