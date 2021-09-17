using System;

namespace ModulosIniciais
{
    class Calculadora {

        private double result;
        public double Result {
            get { return result; }
            private set { result = value; }
        }

        private double numberOne;

        public double NumberOne {
            get { return numberOne; }
            private set {
                Console.Write("Digite o primeiro valor: ");
                Double.TryParse(Console.ReadLine(), out numberOne);
                numberOne = value;
            }
        }

        public void SetNumberOne(bool fatorial = false) {
            if(!fatorial) Console.Write("Digite o primeiro valor: ");
            else Console.Write("Digite o valor para ser calculado o fatorial: ");

            double _numberOne;
            Double.TryParse(Console.ReadLine(), out _numberOne);
            NumberOne = _numberOne;
        }

        private double numberTwo;

        public double NumberTwo {
            get { return numberTwo; }                                   //get -> Retornar o valor da variável para o usuário ou método
            private set {                                               //set -> Salvar o valor na variável
                numberTwo = value;  
            }
        }

        public void SetNumberTwo() {
            double _numberTwo;
            Console.Write("Digite o segundo valor");
            Double.TryParse(Console.ReadLine(), out _numberTwo);
            NumberTwo = _numberTwo;
        }

        private void Fatorial() {
            Result = NumberOne;
            for(int i = ((int) NumberOne - 1); i >= 1; i--) {
                Result *= i;
            }
        }

        /* public void SetNumberOne(bool fatorial = false) {
            if(!fatorial) Console.Write("Digite o primeiro valor: ");
            else Console.Write("Digite o valor para ser calculado o fatorial: ");
            Double.TryParse(Console.ReadLine(), out numberOne);
        } */

        private void Sum() {
            Result = NumberOne + NumberTwo;
        }

        private void Subtract() {
            Result = NumberOne - NumberTwo;
        }

        private void Mult() {
            Result = NumberOne * NumberTwo;
        }

        private void Div() {
            Result = NumberOne / NumberTwo;
        }

        private void Mod() {
            Result = NumberOne % NumberTwo;
        }


        public void SelectOption(int opcao) {
            Menu menu = new Menu();

            switch (opcao)
            {   
                case 0:
                    menu.MenuGeral();
                    break;
                case 1:
                    SetNumberOne();
                    SetNumberTwo();
                    Sum();
                    Console.WriteLine($"A soma dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                    break;
                case 2:
                    SetNumberOne();
                    SetNumberTwo();
                    Mult();
                    Console.WriteLine($"A multiplicação dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                    break;
                case 3:
                    SetNumberOne();
                    SetNumberTwo();
                    Div();
                    Console.WriteLine($"A divisão dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                    break;
                case 4:
                    SetNumberOne();
                    SetNumberTwo();
                    Subtract();
                    Console.WriteLine($"A subtração dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                    break;
                case 5:
                    SetNumberOne();
                    SetNumberTwo();
                    Mod();
                    Console.WriteLine($"O resto da divisão dos dois valores é: {Result}\n");
                    menu.MenuCalc();
                    break;                    
                case 6:                    
                    SetNumberOne(true);
                    Fatorial();
                    Console.WriteLine($"O fatorial do número {NumberOne}! é: {Result}\n")
                    menu.MenuCalc();
                    break;
                default:
                    Console.WriteLine("Opção incorreta, tente novamente\n");
                    menu.MenuCalc();
                    break;
            }
        }
    }
} 