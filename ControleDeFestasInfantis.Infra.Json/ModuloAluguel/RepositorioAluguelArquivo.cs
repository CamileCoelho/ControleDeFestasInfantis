﻿using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.Infra.Json.ModuloFesta
{
    public class RepositorioAluguelArquivo : RepositorioBaseArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelArquivo(ContextoDeDados contexto) : base(contexto)
        {

        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDeDados.festas;
        }
    }
}