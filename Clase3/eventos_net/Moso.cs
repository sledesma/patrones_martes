using System;
using System.Collections.Generic;

namespace eventos_net {

    class Moso {

/*
        public void atender(string cliente) {
            Console.Write("yendo a la mesa del cliente "+cliente);
        }
*/
        public void dispatch(string action, string cliente) {
            switch(action) {
                case "ATENDER":
                    Console.Write("Yendo a la mesa del cliente "+cliente);
                    break;

                case "CERRAR":
                    Console.Write("Cerrando la mesa del cliente "+cliente);
                    break;
            }
        }

    }

    class MapMosoCliente {

        public Dictionary<Moso, Cliente> mapMosoCliente { get; set; }

        public MapMosoCliente() {
            this.mapMosoCliente = new Dictionary<Moso, Cliente>();
        }

    }

    class Cliente {

        private string nombre;

        public Cliente(string nombre) {
            this.nombre = nombre;
        }

        public void solicitarMoso(Moso moso) {
            moso.dispatch("ATENDER", this.nombre);
        }

    }

}