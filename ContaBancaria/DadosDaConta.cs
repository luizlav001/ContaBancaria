using System.Globalization;

namespace ContaBancaria
{
    class DadosDaConta
    {
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double ValorDepos { get; private set; }

        public DadosDaConta(int numConta, string nome)
        {
            NumConta = numConta;
            Nome = nome;
        }

        public DadosDaConta(int numConta, string nome, double depositoInicial) : this(numConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            ValorDepos += quantia;
        }

        public void Saque(double quantia)
        {
            ValorDepos -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                    + NumConta
                    + ", Titular: "
                    + Nome
                    + ", Saldo: $ "
                    + ValorDepos.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
