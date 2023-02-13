using System;
using System.Globalization;

namespace ExercicioPropertiesCsharp
{
    class ContaBancaria
    {
        #region  Atributos

        private int intNumConta = 0;
        private string strNomeTitular = string.Empty;
        private double doSaldo = 0.0;

        #endregion

        #region  Properties

        public int NumConta
        {
            get { return intNumConta; }
            private set { intNumConta = value; }    // => private set impede o número de ser alterado
        }

        public string Nome
        {
            get { return strNomeTitular; }
            set { strNomeTitular = value; }
        }

        public double Saldo
        {
            get { return doSaldo; }
            private set { doSaldo = value; }    // => saldo da conta só pode ser alterado através de depósito ou saque
        }

        #endregion

        #region  Construtores

        public ContaBancaria()
        {

        }

        #endregion

        #region  Métodos

        public void CriaConta(string strNome, double depInicial)
        {
            // Setando os valores
            NumConta = intNumConta + 1;
            Nome = strNome;
            Saldo = depInicial != 0 ? depInicial + doSaldo : 0;
        }

        public void Deposita(int numConta, double valor)
        {
            numConta = NumConta;    // Pega o número da conta
            Saldo = Saldo + valor;
        }

        public void Saque(int numConta, double valor)
        {
            numConta = NumConta;
            Saldo = Saldo - valor - 5;     // 5 = taxa de saque
        }

        // CONSULTA
        public void RealizaConsulta(int numConta)
        {
            NumConta = numConta;
            
            Console.WriteLine("\nDados da Conta:");
            Console.WriteLine("* Conta: " + NumConta);
            Console.WriteLine("* Titular: " + Nome);
            Console.WriteLine("* Saldo: R$" + Saldo);
        }

        #endregion

    }
}
