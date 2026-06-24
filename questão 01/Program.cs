using System;

class Program
{
    static void Main(string[] args)
    {
        int valorPresente = 1000;
        double taxaJuros = 0.053;
        int periodo = 6;
        double valorfinal = valorPresente * Math.Pow(1 + taxaJuros, periodo);
        Console.WriteLine("O valor futuro é: " + valorfinal.ToString("C"));

    }
}