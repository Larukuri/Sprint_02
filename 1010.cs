using System;
using System.Globalization;

class _1010
{

    static void Main(string[] args) {
        string entrada1 = Console.ReadLine();
        string entrada2 = Console.ReadLine();

        string[] produto1 = entrada1.Split(' ');
        string[] produto2 = entrada2.Split(' ');

        int codigo1 = int.Parse(produto1[0]);
        int quantidade1 = int.Parse(produto1[1]);
        double valor1 = double.Parse(produto1[2], CultureInfo.InvariantCulture);

        int codigo2 = int.Parse(produto2[0]);
        int quantidade2 = int.Parse(produto2[1]);
        double valor2 = double.Parse(produto2[2], CultureInfo.InvariantCulture);


        double total1 = quantidade1 * valor1;
        double total2 = quantidade2 * valor2;

        double total = total1 + total2;

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
    }

}