using ControleDeFestasInfantis.Dominio.ModuloItem;

namespace ControleDeFestasInfantis.Dominio.ModuloTema
{
    public interface IRepositorioTema : IRepositorio<Tema>
    {
        void InserirItem(Tema tema, Item item);
    }
}
