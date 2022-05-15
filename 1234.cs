using System;

class _1234
{

    static void Main(string[] args) {

        string lista;
        while ((lista = Console.ReadLine()) != null) {


            int p = 1;

            foreach (char i in lista) {
                if (p % 2 != 0) {
                    if (char.IsWhiteSpace(i)) {
                        Console.Write(i);
                    }
                    else {
                        Console.Write(char.ToUpper(i));
                        p++;
                    }
                }

                else if (p % 2 == 0) {
                    if (char.IsWhiteSpace(i)) {
                        Console.Write(i);
                    }
                    else {
                        Console.Write(char.ToLower(i));
                        p++;
                    }
                }

            }
            Console.Write("\n");
        }
    }
}