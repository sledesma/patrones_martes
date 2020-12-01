using System;

namespace Relaciones.Composicion {

    class Persona {

        public Domicilio domicilio;

        public Persona(Domicilio dom) {
            this.SetDomicilio(dom);
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