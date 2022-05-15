using System;
using System.Globalization;

class _1021
{
    static void Main(string[] args) {

        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int notas = (int)valor;
        int moedas = (int)((valor - notas) * 100);

        int notas100 = notas / 100;
        int rest100 = notas % 100;
        int notas50 = rest100 / 50;
        int rest50 = rest100 % 50;
        int notas20 = rest50 / 20;
        int rest20 = rest50 % 20;
        int notas10 = rest20 / 10;
        int rest10 = rest20 % 10;
        int notas5 = rest10 / 5;
        int rest5 = rest10 % 5;
        int notas2 = rest5 / 2;
        int moeda1 = rest5 % 2;

        int moeda50 = moedas / 50;
        int restm50 = moedas % 50;
        int moeda25 = restm50 / 25;
        int restm25 = restm50 % 25;
        int moeda10 = restm25 / 10;
        int restm10 = restm25 % 10;
        int moeda05 = restm10 / 5;
        int moeda01 = restm10 % 5;

        Console.WriteLine("NOTAS:");
        Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
        Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
        Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
        Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
        Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
        Console.WriteLine(notas2 + " nota(s) de R$ 2.00");

        Console.WriteLine("MOEDAS:");
        Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
        Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
        Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
        Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
        Console.WriteLine(moeda05 + " moeda(s) de R$ 0.05");
        Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");
    }
}
