using System;

namespace Patrones.TemplateMethod {

    class MostrarMensaje {

        public virtual void inicio() {  }
        public virtual void fin() {  }
        public void mostrar(string mensaje) {
            this.inicio(); 
            Console.Write(mensaje);
            this.fin();
        }

    }

}