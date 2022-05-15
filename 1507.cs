using System;

class _1507
{

    static void Main(string[] args) {


        int numeroCasosTeste = int.Parse(Console.ReadLine());


        //laço para cada caso teste
        for (int a = 0; a < numeroCasosTeste; a++) {

            string casoTeste = Console.ReadLine();
            int numQueries = int.Parse(Console.ReadLine());

            //laço para querie do caso teste
            for (int b = 0; b < numQueries; b++) {

                string querie = Console.ReadLine();

                //método para verificar se é uma substring
                static int isSubstring(string casoTeste, string querie) {

                    int tamanhoCasoTeste = casoTeste.Length;
                    int tamanhoQuerie = querie.Length;


                    for (int i = 0; i <= tamanhoQuerie - tamanhoCasoTeste; i++) {
                        int j;

                        for (j = 0; j < tamanhoCasoTeste; j++) {

                            if (querie[i + j] != casoTeste[j]) { break; }
                        }

                        if (j == tamanhoCasoTeste) {
                            return i;
                        }
                    }
                    return -1;
                }


                int resposta = isSubstring(casoTeste, querie);

                if (resposta == -1) { Console.WriteLine("False"); }
                else Console.WriteLine("True");
            }

        }

    }
}