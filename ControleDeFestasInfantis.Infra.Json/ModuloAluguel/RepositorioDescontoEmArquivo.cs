using ControleDeFestasInfantis.Dominio.ModuloAluguel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ControleDeFestasInfantis.Infra.Json.ModuloAluguel
{
    public class RepositorioDescontoEmArquivo : IRepositorioDesconto
    {

        private const string NOME_ARQUIVO = "Compartilhado//Desconto.json";

        public Desconto desconto { get; set; }

        public RepositorioDescontoEmArquivo(bool carregarDados)
        {
            if(carregarDados)
                CarregarDoArquivoJson();
        }

        public void GravarDescontoEmArquivoJson(Desconto novoDesconto)
        {
            desconto = novoDesconto;

            File.WriteAllText(NOME_ARQUIVO, JsonSerializer.Serialize(this, ObterConfiguracoes()));
        }

        public Desconto ObterDesconto()
        {
            return desconto;
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                if(File.ReadAllText(NOME_ARQUIVO).Length > 0)
                    desconto = JsonSerializer.Deserialize<Desconto>(File.ReadAllText(NOME_ARQUIVO), config);
            }
            else
            {
                desconto = new Desconto();
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
