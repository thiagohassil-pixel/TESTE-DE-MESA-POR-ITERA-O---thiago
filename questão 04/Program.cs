﻿class Program
{
    static void Main(string[] args)
    {
        decimal valorPresente = 2000;
        decimal taxaJuros = 0.02m;
        decimal  periodo = 6;
        decimal rendimentoAcumulado = valorPresente;
        decimal rendimentoLiquido;
        decimal saldo;
        decimal saque = 0;
        for (int i = 1; i <= periodo; i++)
        {
            decimal rendimento = valorPresente * (1 + taxaJuros * i);
            rendimentoLiquido = rendimento - valorPresente;
            rendimentoAcumulado += rendimentoLiquido;
            saldo = rendimentoAcumulado;
            saldo -= saque;
            valorPresente -= saque;
            if (i == 4)
            {
                saque = 1000;
            }
            if (i == 5)
            {
                valorPresente = saldo;
            }
            Console.WriteLine($"Mês {i}: Rendimento = {rendimento:C}    Rendimento Acumulado = {rendimentoAcumulado:C}   Rendimento Líquido = {rendimentoLiquido:C}   Saldo = {saldo:C}");
        }
    }
}