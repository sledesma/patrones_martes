using System.Collections.Generic;

namespace Patrones.Facade
{

    // Facade (Fachada)
    class Stock
    {

        private ListaArticulos lista;

        public Stock()
        {
            this.lista = new ListaArticulos();
        }

        public Articulo crearArticulo(int id, string nombre)
        {
            return new Articulo(id, nombre);
        }

        public void agregarItem(Dictionary<int, string> listaArticulos)
        {
            foreach (KeyValuePair<int, string> articulo in listaArticulos)
            {
                this.lista.GetArticulos().Add(this.crearArticulo(articulo.Key, articulo.Value));
            }
        }

    }

}