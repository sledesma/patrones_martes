namespace Patrones.Facade {

    class Articulo {

        public int id { get; set; }
        public string nombre { get; set; }
        
        public Articulo( int id, string nombre ) {
            this.id = id;
            this.nombre = nombre;
        }
        
    }

}