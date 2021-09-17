using System;

namespace ModulosIniciais
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MensagemBoasVindas = "Hello World";

            Console.WriteLine(MensagemBoasVindas);

            /*
            int x = 10;
            float z = 1.5f;
            double a = 1.5; //suporta o dobro do valor de float 
            bool b = true;
            string y = "cadeia de caracteres"; //uma cadeia de caracteres
            char c = "c"; //apenas um caractere
            */

            //Console.WriteLine("Pula linha");
            //Console.Write("Não pula linha");

            Console.WriteLine("Bem vindo a simples calculadora");
            Console.WriteLine("Escolha a operação matemática abaixo: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Multiplicação");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - Resto");
            Console.WriteLine("6 - Sair da calculadora");
            Console.Write("Opção: ");

            //padrão da variavel inteira é 32 bits
            int opcao = Convert.ToInt32(Console.ReadLine());


            if (opcao == 6) {
                Environment.Exit(0);
            } else if (opcao < 1 || opcao > 6) { //AND - E -> && //OR - OU -> || //NOT - NÃO -> !
                Console.WriteLine("Opção incorreta, tente novamente...");
                Environment.Exit(0);
            }

            //Console.Write($"Você escolheu a opção {opcao}\n");
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Double.Parse(Console.ReadLine());
            double valor2;
            Console.Write("Digite o segundo valor: ");
            Double.TryParse(Console.ReadLine(), out valor2);
            //ou double valor1 = Double.Parse(Console.ReadLine());  
            //ou bool convertSucessValue2 = Double.TryParse(Console.ReadLine(), out valor2);

            if (opcao == 1) {
                Console.WriteLine($"A soma dos dois valores é: {valor1 + valor2}");
            }
            else if (opcao == 2) {
                Console.WriteLine($"A soma dos dois valores é: {valor1 * valor2}");
            }
            else if (opcao == 3) {
                Console.WriteLine($"A soma dos dois valores é: {valor1 / valor2}");
            }
            else if (opcao == 4) {
                Console.WriteLine($"A soma dos dois valores é: {valor1 - valor2}");
            }
            else if (opcao == 5) {
                Console.WriteLine($"A soma dos dois valores é: {valor1 % valor2}");
            }
        
        }
    }
}
