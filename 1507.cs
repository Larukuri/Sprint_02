using System;

class _1507
{

    static void Main(string[] args) {


        int numeroCasosTeste = int.Parse(Console.ReadLine());


        //laço para cada caso teste
        for (int a = 0; a < numeroCasosTeste; a++) {

            string casoTeste = Console.ReadLine();
            int numQueries = int.Parse(Console.ReadLine());

            //laço para cada querie do caso teste
            for (int b = 0; b < numQueries; b++) {

                string querie = Console.ReadLine();

                int tamanhoCasoTeste = casoTeste.Length;
                int tamanhoQuerie = querie.Length;


                int p = 0;
                int n = 0;
                for (int i = 0; i < tamanhoQuerie; i++) {


                    for (int m = n; m < tamanhoCasoTeste; m++) {
                        if (casoTeste[m] == querie[i]) {
                            p++;
                            n++;
                            break;
                        }
                        else { n++; }
                    }


                }
                if (p == tamanhoQuerie) {
                    Console.WriteLine("Yes");
                }
                else {
                    Console.WriteLine("No");
                }

            }

        }

    }
}


