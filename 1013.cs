using System;
using System.Globalization;

class _1013
{

    static void Main(string[] args) {
        string entrada = Console.ReadLine();


        string[] numero = entrada.Split(' ');


        int a = int.Parse(numero[0]);
        int b = int.Parse(numero[1]);
        int c = int.Parse(numero[2]);

        int mab = (a + b + (Math.Abs(a - b))) / 2;

        int mabc = (mab + c + (Math.Abs(mab - c))) / 2;





        Console.WriteLine(mabc + " eh o maior");
    }

}