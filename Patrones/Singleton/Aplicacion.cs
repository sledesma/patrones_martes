using System;

namespace Patrones.Singleton {

    class Aplicacion {

        private static Aplicacion app;
        private Aplicacion() { 
            Console.Write("Creando aplicacion");
        } // Constructor privado


        // Método para crear la aplicación si no existe o retornar la ya existente
        public static Aplicacion GetAplicacion() { 
            if(!hayApp()) {
                Aplicacion.app = new Aplicacion();
            }
            return Aplicacion.app;
        }

        private static bool hayApp() { return Aplicacion.app != null; }
    }

}