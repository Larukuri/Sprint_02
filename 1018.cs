using System;
using System.Globalization;

class _1018
{
    static void Main(string[] args) {

        int valor = int.Parse(Console.ReadLine());

        int notas100 = valor / 100;
        int rest100 = valor % 100;
        int notas50 = rest100 / 50;
        int rest50 = rest100 % 50;
        int notas20 = rest50 / 20;
        int rest20 = rest50 % 20;
        int notas10 = rest20 / 10;
        int rest10 = rest20 % 10;
        int notas5 = rest10 / 5;
        int rest5 = rest10 % 5;
        int notas2 = rest5 / 2;
        int notas1 = rest5 % 2;


        Console.WriteLine(valor);
        Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
        Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
        Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
        Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
        Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
        Console.WriteLine(notas2 + " nota(s) de R$ 2,00");
        Console.WriteLine(notas1 + " nota(s) de R$ 1,00");
    }
}