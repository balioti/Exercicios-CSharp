namespace byte_bank
{
    public class newclass
    {
        public string Titular {get; set;}
        public int Agencia {get; set;}
        public int Numero {get; set;}
        public double Saldo {get; set;}

        //Construtor

        public ContaCorrente(int Numero; int Agencia; string Titular; ){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;

        }
    }
}