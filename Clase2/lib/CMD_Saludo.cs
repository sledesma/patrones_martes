using System;
using System.Collections.Generic;

namespace CMD_Saludo
{
    class INICIO
    {
        public void Main()
        {
            Saludar saludo = null;

            Console.WriteLine("Seleccione el lenguaje de la aplicación");
            string lang = Console.ReadLine();

            switch(lang) {
                case "es":
                    saludo = new SaludarEspaniol();
                    break;

                case "en":
                    saludo = new SaludarIngles();
                    break;

                case "dt":
                    saludo = new SaludarAleman();
                    break;
            }

            InvokerSaludar inv = new InvokerSaludar(saludo);
            inv.exec();

        }
    }

    abstract class Saludar {


        public abstract void saludar();
    }

    class SaludarEspaniol : Saludar
    {

        public override void saludar()
        {
            Console.WriteLine("Hola!");
        }
    }

    class SaludarIngles : Saludar
    {
        public override void saludar()
        {
            Console.WriteLine("Hello!");
        }
    }

    class SaludarAleman : Saludar
    {
        public override void saludar()
        {
            Console.WriteLine("Hallo!");
        }
    }

    class InvokerSaludar {
        public Saludar Saludo {get; set;}

        public InvokerSaludar(Saludar saludo) {
            this.Saludo = saludo;
        }

        public void exec() {
            this.Saludo.saludar();
        }
    }

}
