using ControleDeFestasInfantis.Dominio.ModuloTema;

namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Festa
    {
        public Tema tema { get; set; }
        public Endereco endereco { get; set; }
        public DateTime data { get; set; }
        public DateTime horarioInicio { get; set; }
        public DateTime horarioTermino { get; set; }

        public Festa()
        {
            
        }

        public Festa(Tema tema, Endereco endereco, DateOnly data, TimeOnly horarioInicio, TimeOnly horarioTermino)
        {
            this.tema = tema;   
            this.endereco = endereco;
            this.data = data.ToDateTime(TimeOnly.MinValue);
            this.horarioInicio = data.ToDateTime(horarioInicio);
            this.horarioTermino = data.ToDateTime(horarioTermino);
        }
    }
}
