using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Digite um número para calcular o fatorial: ");
        int numero = int.Parse(Console.ReadLine());

        
        Console.Write("Você deseja ver o cálculo passo a passo? (S/N): ");
        string opcao = Console.ReadLine().ToUpper();

        long fatorial = 1;

        
        if (opcao == "S")
        {
   
            Console.Write("Cálculo do fatorial de " + numero + ": ");

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;

                if (i == 1)
                    Console.Write(i);
                else
                    Console.Write(" x " + i);
            }

            Console.WriteLine(" = " + fatorial);
        }
        else
        {
           
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
        }
    }
}
