using System;

namespace Relaciones.Herencia {

    class Bulldog : Perro {

        public override void ladrar() {
            Console.Write("Wow. Soy un Bulldog");
        }

        public void ladrarEnIngles() {
            Console.Write("I'm a Bulldog");
        }

    }

}