using System;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; // Senha correta
            string senhaDigitada; // senha digitada pelo usuário
            int tentativas = 0; // Contador de tentativas
             


            // Loop para solicitar a senha ao usuário
            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++; // Incrementa o contador de tentativas

                // Verifica se a senha digitada é diferente da senha correta
                if (senhaDigitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("Você ainda tem " + (3 - tentativas) + " tentativa(s)");
                    Console.ReadKey();
                }
                else if (senhaDigitada != senha && tentativas == 3)
                {
                    Console.WriteLine("Senha incorreta! Seu Acesso esta bloquedo!");
                    return;
                }
            } while (senhaDigitada != senha);

            Console.Clear();
            Console.WriteLine("Senha Correta! - Tentativas: " + tentativas);
        }
    }
}
