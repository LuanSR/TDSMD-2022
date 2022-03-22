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
        public void Ex3()
        {
            int A, B, C, D, diferenca;

            Console.WriteLine("Digite quatro valores inteiros: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            diferenca = ((A * B) - (C * D));
            Console.WriteLine("A diferença do produto de A e B pelo produto de C e D e de {0}", diferenca);
        }
        public void Ex4(
        {
            int numf;
            float numh, valorh, sal;

            Console.WriteLine("Digite o numero do funcionario: ");
            numf = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas: ");
            numh = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor ganho por hora: ");
            valorh = float.Parse(Console.ReadLine());
            sal = numh * valorh;
            Console.WriteLine("\nNumero: {0}\n\nSalario: R${1:F2}\n", numf, sal);
        }
        
    }
}

