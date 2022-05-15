using System;
using System.Text;
using System.Linq;

class _1251
{

    static void Main(string[] args) {


        string letras;
        var resultado = new StringBuilder();

        while (!string.IsNullOrWhiteSpace(letras = Console.ReadLine())) {

            byte[] valoresASCII = Encoding.ASCII.GetBytes(letras);

            var lista = valoresASCII.GroupBy(i => i);

            var listaordenada = lista.OrderBy(c => c.Count()).ThenByDescending(c => c.Key);

            foreach (var i in listaordenada) {
                resultado.AppendLine($"{i.Key} {i.Count()}");
            }
            resultado.AppendLine();

        }

        resultado.Remove(resultado.Length - 1, 1);

        Console.Write(resultado);
        Console.ReadKey();
    }

}
