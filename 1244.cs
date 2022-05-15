using System;

class _1244
{

    static void Main(string[] args) {

        int ncasos = int.Parse(Console.ReadLine());

        //garante a repetição de acordo com o número informado de entradas e transforma a frase em um array
        for (int i = 0; i < ncasos; i++) {
            string entrada = Console.ReadLine();
            string[] frase = entrada.Split(' ');

            int tamanho = frase.Length;

            //usando o bubble sort para prdenar as palavras
            for (int b = tamanho - 1; b >= 1; b--) {
                for (int a = 0; a < b; a++) {
                    if (frase[a].Length < frase[a + 1].Length) {
                        string aux = frase[a];
                        frase[a] = frase[a + 1];
                        frase[a + 1] = aux;
                    }
                }
            }
            Console.Write(frase[0]);
            for (int j = 1; j < tamanho; j++) {
                Console.Write(" " + frase[j]);
            }

            Console.Write("\n");
        }

    }
}