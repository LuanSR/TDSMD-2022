using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao
{
    public class Solucao
    {
        public void Ex1()
        {
            Console.WriteLine("Exercício 1\n");
            int num1, num2, soma;

            Console.WriteLine("Digite dois numeros inteiros: \n");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("A soma dos numero e igual a: {0}", soma);
        }
        public void Ex2()
        {
            Console.WriteLine("Exercício 2\n");
            double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio de um circulo:\n");
            raio = float.Parse(Console.ReadLine());
            area = pi * (raio * raio);
            Console.WriteLine("A area do circulo e: {0:F2}", area);
        }
        public void Ex3()
        {
            Console.WriteLine("Exercício 3\n");
            int A, B, C, D, diferenca;

            Console.WriteLine("Digite quatro valores inteiros: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            diferenca = ((A * B) - (C * D));
            Console.WriteLine("A diferença do produto de A e B pelo produto de C e D e de {0}", diferenca);
        }
        public void Ex4()
        {
            Console.WriteLine("Exercício 4\n");
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
        public void Ex5()
        {
            Console.WriteLine("Exercício 5\n");
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
        public void Ex6()
        {
            float triangulo(float n1, float n2)
            {
                return (n1 * n2) / 2;
            }
            double circulo(float n1)
            {
                return 3.14159 * (n1 * n1);
            }
            float trapezio(float n1, float n2, float n3)
            {
                return ((n1 + n2) * n3) / 2;
            }
            float quadrado(float n1)
            {
                return n1 * n1;
            }
            float retangulo(float n1, float n2)
            {
                return n1 * n2;
            }

            {
                float A, B, C, areatri, areac, areatra, areaq, arear;

                Console.WriteLine("Digite tres numeros: \n\n");
                A = float.Parse(Console.ReadLine());
                B = float.Parse(Console.ReadLine());
                C = float.Parse(Console.ReadLine());
                areatri = triangulo(A, C);
                Console.WriteLine("\nTriangulo: {0:F3}\n", areatri);
                areac = (float)circulo(C);
                Console.WriteLine("Circulo: {0:F3}\n", areac);
                areatra = trapezio(A, B, C);
                Console.WriteLine("Trapezio: {0:F3}\n", areatra);
                areaq = quadrado(B);
                Console.WriteLine("Quadrado: {0:F3}\n", areaq);
                arear = retangulo(A, B);
                Console.WriteLine("Retangulo: {0:F3}\n", arear);
            }
        }
    }
}

