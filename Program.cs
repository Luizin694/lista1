using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bruno Mattos, Luiz F. C. Roberge, Felipe Ribeiro, Joaquim BMC
            //Atividade: Fazer as 4 operações
            string nome;
            int n1, n2, soma, sub, mult, div;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
           
            soma = n1 + n2;
            sub = n1 - n2;
            div = n1 / n2;
            mult = n1 * n2;

            Console.WriteLine(nome + ", " + "a soma de " + n1 + " e " + n2 + " é igual a: " + soma + "!" );
            Console.WriteLine(nome + ", " + "a subtração de " + n1 + " e " + n2 + " é igual a: " + sub + "!");
            Console.WriteLine(nome + ", " + "a multiplicção de " + n1 + " e " + n2 + " é igual a: " + mult + "!");
            Console.WriteLine(nome + ", " + "a divisão de " + n1 + " e " + n2 + " é igual a: " + div + "!");
            
            Console.ReadKey();
        }
    }
}
