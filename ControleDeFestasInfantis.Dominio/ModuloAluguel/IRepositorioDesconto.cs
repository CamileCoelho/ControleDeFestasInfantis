namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    public interface IRepositorioDesconto
    {
        void GravarDescontoEmArquivoJson(Desconto desconto);
        Desconto ObterDesconto();
    }
}
