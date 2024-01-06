namespace NoteKeeper.Dominio.Compartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : Entidade
    {
        void Editar(TEntidade registro);
        void Excluir(TEntidade registro);
        Task<bool> InserirAsync(TEntidade registro);
        Task<TEntidade> SelecionarPorIdAsync(Guid id);
        Task<List<TEntidade>> SelecionarTodosAsync();
    }
}
