namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    public interface IRepositorioAluguel : IRepositorio<Aluguel>
    {
        List<Aluguel> SelecionarConcluidas();
        List<Aluguel> SelecionarPendentes();
    }
}
