using System;
using System.Collections.Generic;

namespace net
{

    class Pedido
    {
        public string Nombre { get; set; }
        public string Pan { get; set; }
        public string Gusto { get; set; }

        public Pedido(string nombre)
        {
            this.Nombre = nombre;
        }

        public void Mostrar()
        {
            Console.Write("Pedido: " + this.Nombre + "\n");
            Console.Write("Pan: " + this.Pan + "\t" + "Gusto: " + this.Gusto + "\n");
        }

        public virtual void Saludar() {

        }
    }

    /*
     * Recibir un Pedido - Dependencia
     * Retornar el Pedido
     */
    class DecoradorPanOregano : Pedido
    {

        public DecoradorPanOregano(Pedido p) : base(p.Nombre)
        {
            this.Pan = "Cebolla y orégano";
            this.Gusto = p.Gusto;
        }

    }

    class DecoradorGustoPollo : Pedido
    {

        public DecoradorGustoPollo(Pedido p) : base(p.Nombre)
        {
            this.Pan = p.Pan;
            this.Gusto = "Pollo";
        }
    }

    class DecoradorGustoCarne : Pedido
    {

        public DecoradorGustoCarne(Pedido p) : base(p.Nombre)
        {
            this.Pan = p.Pan;
            this.Gusto = "Carne";
        }

        public override void Saludar() {
            Console.Write("Hola, soy un sanguche de carne");
        }
    }

}
