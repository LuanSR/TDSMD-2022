using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao
{
    public class Solucao
    {
        public void Ex1()
        {
                int num1, num2, soma;

                Console.WriteLine("Digite dois numeros inteiros: \n");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                soma = num1 + num2;
                Console.WriteLine("A soma dos numero e igual a: {0}", soma);
        }
        public void Ex2()
        {
        double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio de um circulo:\n");
            raio = float.Parse(Console.ReadLine());
            area = pi * (raio * raio);
            Console.WriteLine("A area do circulo e: {0:F2}", area);
        }
    }
}
