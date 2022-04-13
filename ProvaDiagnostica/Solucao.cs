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
            double preco = 0, total;
            Console.WriteLine("Digite uma opção de produto: ");
            cod = int.Parse(Console.ReadLine());
            switch (cod)
            {
                case 1:
                    preco = 16;
                    break;
                case 2:
                    preco = 25;
                    break;
                case 3:
                    preco = 20;
                    break;
                case 4:
                    preco = 6.50;
                    break;
                case 5:
                    preco = 8;
                    break;
                default:
                    Console.WriteLine("Opção inválida, digite um número de 1 a 5");
                    break;
            }
            Console.WriteLine("Digite a quantidade desse produto: ");
            qnt = int.Parse(Console.ReadLine());
            total = preco * qnt;
            Console.WriteLine("Total : R${0:F2}", total);
        }
        public void Ex4()
        {
            Console.WriteLine("Exercício 2.2");

            double a, b, c;
            double delta, baskara;

            Console.WriteLine("Entre com o valor de A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de C:");
            c = double.Parse(Console.ReadLine());
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("A, B e C devem ser diferentes de 0!");
            }
            else
            {
                delta = ((b*b) -4 * a * c);
                Console.WriteLine("{0}", delta);
                if (delta < 0)
                {
                    Console.WriteLine("Delta não pode ser menor que 0!");
                }
                else if (delta == 0)
                {
                    baskara = -b / (2 * a);
                }
                else
                {
                    baskara = (-(b) + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine(String.Format("1º Valor da Equação do segundo grau:{0}", baskara));
                    baskara = (-(b) - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine(String.Format("2º Valor da Equação do segundo grau:{0}", baskara));
                }

            }
        }
        public void Ex5()
        {
            Console.WriteLine("Exercício 3.1");

            String senha, senhaCerta;
            senhaCerta = "cotil";
            Console.WriteLine("Digite uma senha:");
            senha = Console.ReadLine();
            while (senha != senhaCerta)
            {
                Console.WriteLine("Senha Incorreta!");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido!");
        }
        public void Ex6()
        {
            Console.WriteLine("Exercício 3.2");

            int n, i, x, dentro = 0, fora = 0;

            Console.WriteLine("Digite o número de vezes que um valor será lido");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um número: ");
                
                x = int.Parse(Console.ReadLine());
                if (x >= 1 && x <= 10)
                    dentro++;
                else
                    fora++;
            }
            Console.WriteLine("In: {0}\nOut: {1}", dentro, fora);
        }
    }
}


