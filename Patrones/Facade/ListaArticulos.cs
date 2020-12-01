using System.Collections.Generic;

namespace Patrones.Facade {

    class ListaArticulos {

        private List<Articulo> articulos;
        
        public ListaArticulos() {
            this.articulos = new List<Articulo>();
        }

        public List<Articulo> GetArticulos() {
            return this.articulos;
        }

    }

}