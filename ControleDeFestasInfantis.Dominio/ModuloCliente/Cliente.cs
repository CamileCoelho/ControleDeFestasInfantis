namespace ControleDeFestasInfantis.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int qtdAlugueisRealizados { get; set; }

        public Cliente(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
            this.email = registroAtualizado.email;
        }

        public override string Validar()
        {
            Validador valida = new();

            if (valida.ValidaString(nome))
                return $"Você deve escrever um nome!";

            if (telefone == null || valida.ValidaTelefone(telefone))
                return $"O telefone deve ser no formato (XX)XXXXX-XXXX";

            if (email == null || valida.ValidaFormatoEmail(email))
                return $"O e-mail deve ser no formato xxxxxx@xxxxx.xxx";

            return "";
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
