using System;
using System.Collections.Generic;

namespace list_quickstart {
    class List {
        static void Main (string[] args) {
            var names = new List<string> { "Helton", "Daniel" };
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
                Console.ReadLine();
            }
        }
    }
}