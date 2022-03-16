using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaDiagnostica
{
    public class Solucao
    {
        public void Ex1()
        {
            Console.WriteLine("Exercício 1.1\n");

            int cp1, qp1;
            float pu1;
            int cp2, qp2;
            float pu2;
            float vlrPagar;

            Console.WriteLine("Peça 1");
            cp1 = int.Parse(Console.ReadLine());
            qp1 = int.Parse(Console.ReadLine());
            pu1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Peça 2");
            cp2 = int.Parse(Console.ReadLine());
            qp2 = int.Parse(Console.ReadLine());
            pu2 = int.Parse(Console.ReadLine());

            vlrPagar = (qp1 * pu1) + (qp2 * pu2);
            Console.WriteLine("Valor a ser pago: {0:F2}", vlrPagar);
        }
        public void Ex2()
        {
            Console.WriteLine("Exercício 1.2\n");

            float raio, area;
            double pi = 3.14159;

            Console.WriteLine("Digite o valor o raio de um circulo: ");
            raio = int.Parse(Console.ReadLine());
            area = (float)(pi * (raio * raio));
            Console.WriteLine("A area do circulo e: {0:F2}", area);
        }
        public void Ex3()
        {
            Console.WriteLine("Exercício 2.1\n");

            int cod, qnt;
            Console.WriteLine("Digite uma opção de produto: ");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade desse produto: ");
            qnt = int.Parse(Console.ReadLine());




        }

        }
    }
}
