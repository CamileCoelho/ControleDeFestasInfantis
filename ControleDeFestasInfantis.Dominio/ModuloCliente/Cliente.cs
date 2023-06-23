using ControleDeFestasInfantis.Dominio.ModuloAluguel;

namespace ControleDeFestasInfantis.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : EntidadeBase<Cliente>
    {
        public List<Aluguel> alugueisCliente { get; set; } 
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int qtdAlugueisRealizados { get { return alugueisCliente.Where(x => x.pagamento.pgtoEfetuado == PgtoEfetuadoEnum.Parcial).Count(); } }

        public Cliente()
        {
            
        }

        public Cliente(int id, string nome, string telefone, string email, List<Aluguel> alugueisCliente)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.alugueisCliente = alugueisCliente;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            nome = registroAtualizado.nome;
            telefone = registroAtualizado.telefone;
            email = registroAtualizado.email;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(nome))
                return $"Você deve escrever um nome!";

            if (nome.Length <= 2)
                return $"O nome deve conter no mínimo 3 caracteres!";

            if (email == null || valida.ValidaFormatoEmail(email))
                return $"O e-mail deve ser no formato xxxxxx@xxxxx.xxx";

            if (telefone == null || valida.ValidaTelefone(telefone))
                return $"O telefone deve ser no formato (XX)9XXXX-XXXX";

            return "";
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
