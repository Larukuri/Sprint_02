using System;
using System.Globalization;

class _1009
{

    static void Main(string[] args) {

        var nome = Console.ReadLine();
        double fixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        double total = fixo + (vendas * 0.15);

        Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));

    }

}