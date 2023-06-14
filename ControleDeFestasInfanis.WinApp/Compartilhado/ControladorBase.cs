namespace ControleDeFestasInfantis.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual string? ToolTipFiltrar { get { return "Filtro indisponível"; } }

        public virtual string? ToolTipAdicionarItens { get { return "Adição indisponível"; } }

        public virtual string? ToolTipConcluirItens { get { return "Conclusão indisponível"; } }
   //     public virtual string ToolTipVisualizar { get { return "Visualização indisponível"; } }
        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return true; } }
        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool FiltrarHabilitado { get { return true; } }
        public virtual bool AdicionarItensHabilitado { get { return true; } }
        public virtual bool ConcluirItensHabilitado { get { return true; } }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Filtrar() { }

        public virtual void AdicionarItens() { }

        public virtual void ConcluirItens() { }

        public virtual void Visualizar()
        {

        }
        
        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();

    }
}
