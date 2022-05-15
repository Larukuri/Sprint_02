using System;
using System.Globalization;

class _1019
{
    static void Main(string[] args) {

        int valor = int.Parse(Console.ReadLine());

        int horas = valor / 3600;
        int resthoras = valor % 3600;
        int minutos = resthoras / 60;
        int segundos = resthoras % 60;




        Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);

    }
}
