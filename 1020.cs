using System;
using System.Globalization;

class _1020
{
    static void Main(string[] args) {

        int valor = int.Parse(Console.ReadLine());

        int anos = valor / 365;
        int restanos = valor % 365;
        int meses = restanos / 30;
        int dias = restanos % 30;




        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");

    }
}
