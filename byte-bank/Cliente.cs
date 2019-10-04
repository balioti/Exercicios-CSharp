namespace byte_bank
{
    public class Cliente
    {
        public string Cpf {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}

        public Cliente(string nome, string cpf, string email){
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
        }

        public bool TrocarSenha(string senha) {
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this.Senha = senha;
                return true;
            } else {
                return false;
            }
        }


    }
}