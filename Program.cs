using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            double area;
            double altura;

            Console.WriteLine("Informe a forma geometrica" +
                "\n 1 - Quadrado" +
                "\n 2 - Retangulo" +
                "\n 3 - Trapezio" +
                "\n 4 - Losango" +
                "\n");
            int forma = int.Parse(Console.ReadLine());

            switch (forma)
            {
                case 1:
                    Console.Write("Informe a medida do quadrado: ");
                    double lado = double.Parse(Console.ReadLine());

                    area = lado * lado;

                    Console.Write("A Area do Quadrado é: " + area + "m²");

                    break;

                case 2:
                    Console.Write("Informe a medida da base: ");
                    double baseretangulo = double.Parse(Console.ReadLine());

                    Console.Write("Informe a medida da Altura: ");
                    altura = double.Parse(Console.ReadLine());

                    area = baseretangulo * altura;

                    Console.Write("A Area do Retangulo é: " + area + "m²");

                    break;

                case 3:
                    Console.Write("Informe a medida da Base Maior: ");
                    double baseMaior = double.Parse(Console.ReadLine());

                    Console.Write("Informe a medida da Base Menor: ");
                    double baseMenor = double.Parse(Console.ReadLine());

                    Console.Write("Informe a medida da Altura: ");
                    altura = double.Parse(Console.ReadLine());

                    area = (baseMaior + baseMenor) * altura;
                    area = area / 2;

                    Console.Write("A Area do Trapézio é: " + area + "m²");

                    break;

                case 4:
                    Console.Write("Informe a medida da Diagonal Maior: ");
                    double diagonalMaior = double.Parse(Console.ReadLine());

                    Console.Write("Informe a medida da Diagonal Menor: ");
                    double diagonalMenor = double.Parse(Console.ReadLine());

                    area = (diagonalMaior * diagonalMenor) / 2;

                    Console.Write("A Area do Losango é: " + area + "m²");

                    break;

                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }
                    Console.ReadKey();
            
                
        }
    }
}
