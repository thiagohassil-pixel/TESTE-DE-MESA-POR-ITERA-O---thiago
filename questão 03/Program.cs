class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor presente: ");
        decimal valorPresente = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite a taxa de juros: ");
        decimal taxaJuros = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite o período: ");
        int periodo = Convert.ToInt32(Console.ReadLine());
        decimal rendimento = valorPresente * (decimal)Math.Pow((double)(1 + (taxaJuros/100)), periodo);
        Console.WriteLine($"O rendimento é: {rendimento:C}");
    }
}