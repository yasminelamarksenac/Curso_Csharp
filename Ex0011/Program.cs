namespace Ex0011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor da casa: R$");
            double valorCasa = double.Parse(Console.ReadLine());

            Console.Write("Informe o salário do comprador? ");
            double salario = int.Parse(Console.ReadLine());

            Console.Write("Em quantos anos deseja pagar");
            int anos = int.Parse(Console.ReadLine());

            int meses = anos * 12;
            double prestacao = valorCasa / meses;

            double limite = salario * 0.3;

            Console.WriteLine("n--- Resultado ---");
            if (prestacao <= limite)
            {
                Console.WriteLine("Empréstimo aprovado!");
                Console.WriteLine($"Prestação mensal de R$ {prestacao:F2} excede 30% do salário (R$ {limite:F2}.");
            }
        }
    }

}