using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasFigurasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figura = "";

            inicio:
            Menu();
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcao) {


                case 1:

                    Console.Write("Insira o tamanho do lado do quadrado:");
                    double tamanhoLado = double.Parse(Console.ReadLine());

                    Quadrado(tamanhoLado, figura = "Quadrado");
                        
                    break;

                case 2:
                    Console.Write("Insira o comprimeto do retângulo:");
                    double basse = double.Parse(Console.ReadLine());

                    Console.Write("Insira a altura do retângulo:");
                    double altura = double.Parse(Console.ReadLine());

                    Retangulo (basse, altura, figura = "Retângulo");
                    break;

                case 3:

                    Console.Write("Insira o raio do circulo:");
                    double raio = double.Parse(Console.ReadLine());
                    Circulo(raio, figura = "Circulo");

                    break;

                case 4:

                    Console.Write("Insira a base do triângulo:");
                    basse = double.Parse(Console.ReadLine());

                    Console.Write("Insira a altura do triângulo:");
                    altura = double.Parse(Console.ReadLine());

                    Triangulo(basse, altura, figura = "Triângulo");
                    break;

                default:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A opção inválida!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }


           
            Console.WriteLine();
            Console.WriteLine("Deseja continuar a calcular as áreas? (y/n)");
            string sair = Console.ReadLine();
            sair = sair.ToLower();

            if (sair == "y")
            {
          
                Console.Clear();
                goto inicio;

            }
            else if (sair == "n")
            {
                Environment.Exit(0);
                
 
            }
    
        }

        static void Quadrado(double tamanhoLado, string figura ) {


            double area = Math.Pow(tamanhoLado, 2);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A figura {figura} tem a área de: {area}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Retangulo(double basee, double altura, string figura) {

            double area = basee * altura;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A figura {figura} tem a área de: {area}");
            Console.ForegroundColor = ConsoleColor.White;



        }

        static void Circulo(double raio, string figura) {

            double pi = 3.14;

            double area = pi * (Math.Pow(raio,2));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A figura {figura} tem a área de: {area}");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Triangulo (double basee, double altura, string figura)
        {
            double area = (basee * altura)/2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A figura {figura} tem a área de: {area}");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Menu() {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("*** Áreas de Figuras Geométricas ***");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Retângulo");
            Console.WriteLine("3 - Circulo");
            Console.WriteLine("4 - Triângulo");
            Console.WriteLine();
            Console.Write("Digite uma das opções:");
            
        }
    }
}
