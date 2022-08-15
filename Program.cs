using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Clear();//Serve para limpar a tela
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
             
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite uma opção: ( + ||  - ||  * ||  / || % ) : ");
            char opc = char.Parse(Console.ReadLine());

            switch (opc)
            {
                default:
                    goto Inicio;
                case '+':
                    int soma = num1 + num2; 
                    Console.WriteLine("A soma dos números é igual a " + soma);
                    break;
                case '-':
                    int sub = num1 - num2;
                    Console.WriteLine("A subtração dos números é igual a " + sub);
                    break;
                case '*':
                    int mult = num1 * num2; 
                    Console.WriteLine("A multiplicação dos números é igual a " + mult);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0");
                        goto Inicio;
                    }
                    else
                    {
                        int div = num1 / num2;
                        Console.WriteLine("A divisão dos números é igual a " + div);
                    }
                    break;
                case '%':
                    int resto = num1 % num2;
                    Console.WriteLine("O resto da divisão dos números é igual a " + resto);
                    break;

            }

            Console.WriteLine("\nContinuar calculando? (s | n): ");
            char continuar = char.Parse(Console.ReadLine());

            if(continuar == 's' || continuar == 'S')
            {
                goto Inicio;
            }

            Console.ReadKey();
        }
    }
}
