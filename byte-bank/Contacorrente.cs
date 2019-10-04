namespace byte_bank
{
    public class Contacorrente
    {
        public Cliente Titular {get; set;}
        public int Agencia {get; set;}
        public int Numero {get; set;}
        public double Saldo {get; set;}

        //Construtor

        public Contacorrente(int Numero, int Agencia, Cliente Titular ){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }

        public double Deposito(double valor){
            this.Saldo += valor;
            return this.Saldo;
        }

        public bool Saque(double valor){
            if(valor < this.Saldo){
                this.Saldo -= valor;
                return true;
            }   else{
                    return false;
            }
        }

        public bool Transferencia(Contacorrente destino, double valor){}



    }
}