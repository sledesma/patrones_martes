using System;

namespace ChainOfResponsability.Router
{
    class Inicio
    {
        public void Main(string[] args)
        {
            RouteHandler inicio = new HomePage();
            RouteHandler acercaDe = new AcercadePage();

            inicio.SetSiguiente(acercaDe);

            Console.WriteLine("¿Que pagina deseas ver?");
            string page = Console.ReadLine();

            Console.WriteLine("¿Para que la quieres ver?");
            string prop = Console.ReadLine();

            inicio.ManejarRuta(page, prop);
        }
    }

    abstract class RouteHandler
    {

        protected RouteHandler Siguiente;

        public void SetSiguiente(RouteHandler next)
        {
            this.Siguiente = next;
        }

        public abstract void ManejarRuta(string pagina, string proposito);

    }

    class HomePage : RouteHandler
    {
        public override void ManejarRuta(string pagina, string proposito)
        {
            if (pagina == "home")
            {
                switch (proposito)
                {
                    case "leer":
                        Console.WriteLine("Leyendo HOME\n");
                        break;
                    case "escribir":
                        Console.WriteLine("Escribiendo HOME\n");
                        break;
                }
            }
            else if (this.Siguiente != null)
            {
                this.Siguiente.ManejarRuta(pagina, proposito);
            }
        }
    }

    class AcercadePage : RouteHandler
    {
        public override void ManejarRuta(string pagina, string proposito)
        {
            if (pagina == "acercade")
            {
                switch (proposito)
                {
                    case "leer":
                        Console.WriteLine("Leyendo ACERCA DE\n");
                        break;
                    case "escribir":
                        Console.WriteLine("Escribiendo ACERCA DE\n");
                        break;
                }
            }
            else if (this.Siguiente != null)
            {
                this.Siguiente.ManejarRuta(pagina, proposito);
            }
        }
    }

}