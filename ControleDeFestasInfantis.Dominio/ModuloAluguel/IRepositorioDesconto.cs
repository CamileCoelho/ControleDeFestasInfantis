using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFestasInfantis.Dominio.ModuloAluguel
{
    public interface IRepositorioDesconto
    {
        void GravarDescontoEmArquivoJson(Desconto desconto);
        Desconto ObterDesconto();
    }
}
