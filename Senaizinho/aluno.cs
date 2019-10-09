namespace Senaizinho
{
    public class aluno
    {
        public string nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Curso {get; set;}
        public int numeroSala {get; set;}

        //Construtor
        public Aluno(string nome, DateTime dataNascimento, string curso){
            this.nome = nome;
            this.DataNascimento = dataNascimento;
            this.Curso = curso;
        }

    }
}