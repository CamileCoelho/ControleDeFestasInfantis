namespace ControleDeFestasInfantis.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int qtdAlugueisRealizados { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.qtdAlugueisRealizados = 0;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            nome = registroAtualizado.nome;
            telefone = registroAtualizado.telefone;
            email = registroAtualizado.email;
            qtdAlugueisRealizados = registroAtualizado.qtdAlugueisRealizados;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(nome))
                return $"Você deve escrever um nome!";

            if (nome.Length <= 4)
                return $"O nome deve conter no mínimo 5 caracteres!";

            if (email == null || valida.ValidaFormatoEmail(email))
                return $"O e-mail deve ser no formato xxxxxx@xxxxx.xxx";

            if (telefone == null || valida.ValidaTelefone(telefone))
                return $"O telefone deve ser no formato (XX)XXXXX-XXXX";

            return "";
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
