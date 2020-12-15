using System;

namespace Patrones.TemplateMethod {

    class MensajeHola : Mensaje {

        protected override string finLinea() { return "\n"; }

        protected override string inicio(string msj) { return "Hola \n"; }

    }

}