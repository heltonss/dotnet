using System;
using System.Collections.Generic;

namespace studyCsharp {
    class Program {
        static void Main (string[] args) {
            workingStringList ();
        }

        public static void workingStringList () {
            // listas de string 
            var names = new List<string> { "Helton", "Daniel" };
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }

            // modificando a lista
            Console.WriteLine ();
            names.Add("João");
            names.Add("Maria");
            names.Add("Joaquim");
            names.Remove("Helton");
            foreach (var name in names) {
                Console.WriteLine ($"Alterando {name.ToUpper()}!");
            }

            //usando indices
            Console.WriteLine();
            Console.WriteLine($"Primeiro indice/nome da lista {names[0]}");
            Console.WriteLine($"Segundo indice/nome da lista {names[1]}");
            Console.WriteLine($"A lista tem {names.Count} pessoas");

            //fazendo  uma busca na lista
            Console.WriteLine();
            var index = names.IndexOf ("Daniel");
            if (index == -1) {
                Console.WriteLine ($"Quando um item não é encontrado o indice retorna {index}");
            } else {
                Console.WriteLine ($"O nome {names[index]} esta no indice {index}");
            }
        }

    }
}