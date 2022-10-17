using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Bem-vindo a Calculadora");
            Console.WriteLine($"Qual operação você deseja realizar?");
            Console.WriteLine($"Digite 1 para Somar");
            Console.WriteLine($"Digite 2 para Subtrair");
            Console.WriteLine($"Digite 3 para Multiplicar");
            Console.WriteLine($"Digite 4 para Dividir");
            Console.WriteLine($"Digite 0 para Sair");
            string? entrada = Console.ReadLine();
            int op;
            bool valida = int.TryParse(entrada, out op);
            if (valida == true) {
                do {
                    switch (op)
                    {
                        case 0:
                            Console.WriteLine($"Você saiu do programa");
                            break;
                        case 1:
                            Console.WriteLine($"Digite o primeiro valor: ");
                            string? valor1 = Console.ReadLine();
                            Console.WriteLine($"Digite o segundo valor: ");
                            string? valor2 = Console.ReadLine();
                            int x1;
                            int y1;
                            bool verifica1 = int.TryParse(valor1, out x1);
                            bool verifica2 = int.TryParse(valor2, out y1);
                            if ((verifica1 == true) && (verifica2 == true)) {
                                int soma = x1 + y1;
                                Console.WriteLine($"{x1} + {y1} = {soma}");
                            } else {
                                Console.WriteLine($"Nenhum dos valores pode ser nulo.");
                            }
                            break;
                        case 2:
                            Console.WriteLine($"Digite o primeiro valor: ");
                            string? valor3 = Console.ReadLine();
                            Console.WriteLine($"Digite o segundo valor: ");
                            string? valor4 = Console.ReadLine();
                            int x2;
                            int y2;
                            bool verifica3 = int.TryParse(valor3, out x2);
                            bool verifica4 = int.TryParse(valor4, out y2);
                            if ((verifica3 == true) && (verifica4 == true)) {
                                int subtracao = x2 - y2;
                                Console.WriteLine($"{x2} - {y2} = {subtracao}");
                            } else {
                                Console.WriteLine($"Nenhum dos valores pode ser nulo.");
                            }
                            break;
                        case 3:
                            Console.WriteLine($"Digite o primeiro valor: ");
                            string? valor5 = Console.ReadLine();
                            Console.WriteLine($"Digite o segundo valor: ");
                            string? valor6 = Console.ReadLine();
                            int x3;
                            int y3;
                            bool verifica5 = int.TryParse(valor5, out x3);
                            bool verifica6 = int.TryParse(valor6, out y3);
                            if ((verifica5 == true) && (verifica6 == true)) {
                                int multiplicacao = x3 * y3;
                                Console.WriteLine($"{x3} x {y3} = {multiplicacao}");
                            } else {
                                Console.WriteLine($"Nenhum dos valores pode ser nulo.");
                            }
                            break;
                        case 4:
                            Console.WriteLine($"Digite o primeiro valor: ");
                            string? valor7 = Console.ReadLine();
                            Console.WriteLine($"Digite o segundo valor: ");
                            string? valor8 = Console.ReadLine();
                            int x4;
                            int y4;
                            bool verifica7 = int.TryParse(valor7, out x4);
                            bool verifica8 = int.TryParse(valor8, out y4);
                            if ((verifica7 == true) && (verifica8 == true)) {
                                double divisao = x4 / y4;
                                Console.WriteLine($"{x4} / {y4} = {divisao}");
                            } else {
                                Console.WriteLine($"Nenhum dos valores pode ser nulo.");
                            }
                            break;
                        default:
                            Console.WriteLine($"Opção Inválida!");
                            break;
                    }
                } while (op != 0);
            } else {
                Console.WriteLine("A operação não pode ser nula.");
            }
        }
    }
}