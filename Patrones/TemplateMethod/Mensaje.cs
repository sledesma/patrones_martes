using System;

namespace Patrones.TemplateMethod {

    class Mensaje {

        protected virtual string finLinea() { return "\n"; }

        protected virtual string inicio(string msj) { return ""; }

        public void log(string msj) {
            Console.Write(this.inicio(msj));
            Console.Write(msj);
            Console.Write(this.finLinea());
        }

    }

}