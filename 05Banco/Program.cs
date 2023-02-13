using System;
using System.Globalization;

namespace ExercicioPropertiesCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            string strOperacao = string.Empty;
            string strContinua = string.Empty;
            int numConta = 0;
            double valor = 0.0;

            Console.WriteLine("*** Bem vindo ao Nubank! ***");
            Console.WriteLine("****************************\n");

            Iniciar();

            void Iniciar()
            {
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Criar nova conta");
                Console.WriteLine("2 - Consultar dados da conta");
                Console.WriteLine("3 - Novo depósito");
                Console.WriteLine("4 - Novo Saque");
                Console.WriteLine("5 - Sair");
                Console.Write("\nOperação: ");

                strOperacao = Console.ReadLine();

                if (strOperacao == "1")
                {
                    Console.WriteLine("Operação selecionada: Criar nova conta");
                    CriarConta();
                }
                else if (strOperacao == "2")
                {
                    //Console.WriteLine("Em desenvolvimento. Selecione outra opção.\n");
                    //Iniciar();

                    Console.WriteLine("Operação selecionada: Consulta");
                    Console.Write("\nDigite o número da conta: ");
                    numConta = Convert.ToInt32(Console.ReadLine());
                    conta.RealizaConsulta(numConta);
                }
                else if (strOperacao == "3")
                {
                    Console.WriteLine("Operação selecionada: Depósito");
                    RealizaDeposito();
                }
                else if (strOperacao == "4")
                {
                    Console.WriteLine("Operação selecionada: Saque");
                    RealizaSaque();
                }
                else if (strOperacao == "5")
                {
                    Sair();
                }
                else
                {
                    Console.WriteLine("Operação inválida!\n");
                    Iniciar();
                }

            }

            // CRIA CONTA
            void CriarConta()
            {
                string newNome = string.Empty;
                double newDepo = 0.0;

                Console.Write("\nDigite seu nome completo: ");
                newNome = Console.ReadLine();

                Console.Write("Deseja fazer um depósito inicial? Digite [s] para SIM ou [n] para NÃO: ");
                string depInicial = Console.ReadLine();

                if (depInicial == "s" || depInicial == "S")
                {
                    Console.Write("Valor a depositar: R$");
                    newDepo = Convert.ToDouble(Console.ReadLine());

                    while (newDepo <= 0.0)
                    {
                        Console.WriteLine("\nO valor deve ser maior que 0.");
                        Console.Write("Digite novamente um valor a depositar: R$");
                        newDepo = Convert.ToDouble(Console.ReadLine());
                    }
                }
                else if ((depInicial != "s" || depInicial != "S") && (depInicial != "n" || depInicial != "N"))
                {
                    Console.WriteLine("Operação Inválida!");
                    CriarConta();
                }

                conta.CriaConta(newNome, newDepo);
                Sucesso();
                Continuar();
            }

            // DEPOSITO
            void RealizaDeposito()
            {
                Console.Write("\nDigite o número da conta: ");
                numConta = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor para depósito: R$");
                valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (valor <= 0.0)
                {
                    Console.WriteLine("O valor deve ser maior que 0.");
                    RealizaDeposito();
                }

                conta.Deposita(numConta, valor);
                Sucesso();
                Continuar();
            }

            // SAQUE
            void RealizaSaque()
            {
                Console.Write("\nDigite o número da conta: ");
                numConta = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor para saque: R$");
                valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (valor <= 0.0)
                {
                    Console.WriteLine("O valor deve ser maior que 0.");
                    RealizaSaque();
                }

                conta.Saque(numConta, valor);
                Sucesso();
            }

            // MENSAGEM DE SUCESSO
            void Sucesso()
            {
                Console.WriteLine("\n************************");
                Console.WriteLine("Sucesso! Dados da Conta:");
                Console.WriteLine("* Conta: " + conta.NumConta);
                Console.WriteLine("* Titular: " + conta.Nome);
                Console.WriteLine("* Saldo: R$" + conta.Saldo);
                Console.WriteLine("************************");
            }

            void Continuar()
            {
                Console.Write("\nDeseja continuar? [1] para CONTINUAR ou [2] para SAIR: ");
                strContinua = Console.ReadLine();

                if (strContinua == "1")
                {
                    Console.WriteLine("\n");
                    Iniciar();
                }
                else if (strContinua == "2")
                {
                    Sair();
                }
                else
                {
                    Console.WriteLine("\nOperação Inválida. Processo finalizado.");
                }
            }

            void Sair()
            {
                Console.WriteLine("\n~~ Até logo! ~~");
            }

        }
    }
}
