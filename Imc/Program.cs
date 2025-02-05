namespace Imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"n Seu Imc é: {imc:F2}");

            if (imc < 18.5)
                Console.WriteLine("Classificação: Abaixo do peso");
            else if (imc < 24.9)
                Console.WriteLine("Classificação: Peso normal");
            else if (imc < 29.9)
                Console.WriteLine("Classificação: Sobrepeso");
            else if (imc < 34.9)
                Console.WriteLine("Obesidade Grau I");
            else if (imc < 39.9)
                Console.WriteLine("Obesidade Grau II");
            else
                Console.WriteLine("Classificação: Obesidade Grau III (Mórbida)");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.WriteLine();



        }
    }
}
