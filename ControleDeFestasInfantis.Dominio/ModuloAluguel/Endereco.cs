using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    [Serializable]
    public class Endereco
    {
        public string cidade { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }

        public Endereco()
        {
            
        }

        public Endereco(string cidade, string rua, int numero)
        {
            this.cidade = cidade;
            this.rua = rua;
            this.numero = numero;
        }
    }
}
