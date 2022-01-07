using System;

namespace CalculodeAreas{
    class Calculos{
        public static void Menu(){
            Console.Clear();
            Console.WriteLine("Olá, Seja Bem-Vindo(a)");
            Console.WriteLine("Você deseja calcular a área de um Triângulo ou de um Retângulo?");
            Console.WriteLine("1 - Triângulo    |   2 - Retângulo |   0 - Sair do Programa");
            int Escolha = int.Parse(Console.ReadLine());

            switch(Escolha){
                case 1: Triangulo(); break;
                case 2: Retangulo(); break;
                case 0: Environment.Exit(0); break;
                default: Menu(); break;
            }

            /*if((Escolha != 1) || (Escolha != 2) || (Escolha != 0)){
                throw new FormatException("Por favor, Digite os números corretos");
            }*/

            Console.WriteLine("");
            Console.WriteLine("Deseja fazer outro calculo?");
            Console.WriteLine("1 - SIM  | 0 - NÃO");
            var escolha2 = int.Parse(Console.ReadLine());

            switch(escolha2){
                case 1: Menu(); break;
                case 0: Environment.Exit(0); break;
                default: Saindo(); break;
            }

        }

        public static void Retangulo(){
            Console.Clear();
            try{
                Console.WriteLine("Digite a base do Retângulo: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do Retângulo: ");
                double altura = double.Parse(Console.ReadLine());

                var resultado = b * altura;

                Console.WriteLine($"A área do Retângulo é {resultado}");
            }
            catch{
                Console.WriteLine("Por favor, informe apenas números");
            }
        }

        public static void Triangulo(){
            Console.Clear();
            try{
                Console.WriteLine("Digite a base do Triangulo: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do Triangulo: ");
                double altura = double.Parse(Console.ReadLine());

                var resultado = (b * altura)/2;

                Console.WriteLine($"A área do Triangulo é {resultado}");
            }
            catch{
                Console.WriteLine("Por favor, informe apenas números");
            }
        }
        public static void Saindo(){
            Console.WriteLine("");
            Console.WriteLine("Essa opção não existe, pressione qualquer tecla para sair");
            Console.ReadKey();        
        }
    }
}