using System;

namespace Patrones.TemplateMethod {

    class SaludarPrimero : MostrarMensaje {

        public override void inicio() { 
            Console.Write("Hola mundo\n");
        }

    }

}