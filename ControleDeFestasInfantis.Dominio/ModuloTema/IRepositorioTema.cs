using ControleDeFestasInfantis.Dominio.ModuloItem;

namespace ControleDeFestasInfantis.Dominio.ModuloTema
{
    public interface IRepositorioTema : IRepositorio<Tema>
    {
        void AdcionarItens(List<Item> itens, Tema tema);

        void RemoverItens(List<Item> itens, Tema tema);
    }
}
