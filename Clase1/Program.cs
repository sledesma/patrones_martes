using System;
using System.Collections.Generic;
using Patrones.Facade;

namespace patrones
{

    class Program
    {
        static void Main(string[] args)
        {
            Stock st = new Stock();

            Dictionary<int, string> articulos = new Dictionary<int, string>();

            articulos.Add(1, "Celular");
            articulos.Add(2, "Telefono");
            articulos.Add(3, "Teclado");

            st.agregarItem(articulos);

            // Formatearlo con JSON
        }
    }

}
