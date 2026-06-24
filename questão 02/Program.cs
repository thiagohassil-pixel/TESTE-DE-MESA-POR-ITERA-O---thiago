using System.Globalization;
class Program 
{
    static void Main(string[] args)
    {
        decimal valorPresente = 3800m;
        decimal taxaJuros = 0.0125m;
        int periodo = 6;
        decimal rendimento;
        decimal rendaAcumulada = valorPresente;
        decimal rendimentoLiquido = 0m;

        CultureInfo culture = new CultureInfo("pt-BR");
        Console.WriteLine($"{"Loop",-10}{"taxa",10}{"rendimento",14}{"renda acumulada",15}{"rendimento líquido",17}");

        for (int loop = 0; loop < periodo; loop++)
        {
            rendimento = rendaAcumulada * taxaJuros;
            rendaAcumulada += rendimento;
            rendimentoLiquido = rendaAcumulada - valorPresente;

            Console.WriteLine(
                $"{loop + 1,-10}"+
                $"{"1,25%",10}"+
                $"{rendimento.ToString("C2", culture),14}"+
                $"{rendaAcumulada.ToString("C2", culture),15}"+
                $"{rendimentoLiquido.ToString("C2", culture),17}");
        }

Console.ReadLine();
    }
    
}
