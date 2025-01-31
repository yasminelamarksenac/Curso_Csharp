namespace Escrever
{
    internal class Program
    {
        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('*', tam);
            string textoCentralizado =  texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(texto);
            Console.WriteLine(linha);

        }

        static void Main(string[] args)
        {
            Escrever("Yasmine Nascimento Lamark");
            Console.WriteLine();
            Escrever("Futura Programadora");
            Console.WriteLine();
            Escrever("Você Consegue!");
            Console.WriteLine();
        }
    }
}
