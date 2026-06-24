class Program
{
    static void Main(string[] args)
    {
        decimal valorFuturo = 7390.61m;
        decimal taxaJuros = 0.0125m;
        int periodo = 2 * 12;
        decimal valorPresente = valorFuturo / (decimal)Math.Pow((double)(1 + taxaJuros), periodo);
        Console.WriteLine($"O valor presente é: {valorPresente:C}");
    }
}