using System;

namespace Relaciones.Agregacion {

    class Persona {

        public Domicilio domicilio;

        public Persona() {

        }

        public void saludar(string mensaje) {
            Console.Write(mensaje);
        }

        public void SetDomicilio(Domicilio d) {
            this.domicilio = d;
        }

        public Domicilio GetDomicilio() {
            return this.domicilio;
        }

    }

}