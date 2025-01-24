namespace Ex0015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Digite o gênero: ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite o gênero: ");
                genero = Console.ReadLine();
            }
            Console.WriteLine("Bem-Vindos e bem-vindes ao curso de C#!");
        }
          
    }
}
