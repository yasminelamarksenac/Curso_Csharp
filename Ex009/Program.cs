﻿namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.WriteLine("==================================");
            Console.WriteLine("Programa para Testar Triângulos");
            Console.WriteLine("==================================");

            Console.Write("Digite o valor do lado A:");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triângulo.");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("E ele é um triângulo Equilátero");
                }
                else if ((ladoA == ladoB) || (ladoA == ladoC))
                {
                    Console.Write("E ele é um Triângulo Isóceles .");
                }
                else
                {
                    Console.WriteLine("E ele é um Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triângulo. ");
                
            }
        }
    }
}
