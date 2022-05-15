using System;
using System.Collections.Generic;
using System.Linq;

class _1259
{

    static void Main(string[] args) {

        int ncasos = int.Parse(Console.ReadLine());
        int[] numeros = new int[ncasos];

        //recebendo os números e colocando na array numeros
        for (int i = 0; i < ncasos; i++) {
            numeros[i] = int.Parse(Console.ReadLine());

        }

        //criando as listas que vão receber par ou impar

        List<int> pares = new List<int>();
        List<int> impares = new List<int>();


        //copiando os valores de entrada para as arrays
        foreach (int i in numeros) {
            if (i % 2 == 0) {

                pares.Add(i);
            }
            else {

                impares.Add(i);
            }

        }


        foreach (var item in pares.OrderBy(x => x)) {
            Console.WriteLine(item);
        }
        foreach (var item in impares.OrderByDescending(x => x)) {
            Console.WriteLine(item);
        }
    }

}