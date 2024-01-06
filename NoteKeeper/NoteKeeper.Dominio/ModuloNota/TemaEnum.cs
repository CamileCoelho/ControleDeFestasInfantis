using System.ComponentModel;

namespace NoteKeeper.Dominio.ModuloNota
{

    public enum TemaEnum
    {
        [Description("primary")]
        Basico,
        [Description("accent")]
        Realçada,
        [Description("warn")]
        Advertencia
    }
}

