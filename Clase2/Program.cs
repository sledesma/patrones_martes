using System;
using System.Collections.Generic;

namespace patrones
{
    class Program
    {
        static void Main(string[] args)
        {
            Lang saludo = null;

            Console.WriteLine("Seleccione el lenguaje de la aplicación");
            string lang = Console.ReadLine();

            switch(lang) {
                case "es":
                    saludo = new Es();
                    break;

                case "en":
                    saludo = new En();
                    break;

                case "dt":
                    saludo = new Dt();
                    break;
            }

            LangInterface idioma = new LangInterface(saludo);
            Console.WriteLine(idioma.Get("SALUDO"));
            Console.WriteLine(idioma.Get("DESPEDIDA"));

        }
    }

    abstract class Lang {

        public Dictionary<string, string> Dict;

        public Lang() {
            this.Dict = new Dictionary<string, string>();
        }

        public abstract void configLang();



    }

    class Es : Lang
    {
        public override void configLang()
        {
            this.Dict.Add("SALUDO", "Hola!");
            this.Dict.Add("DESPEDIDA", "Adios!");
        }
    }

    class En : Lang
    {
        public override void configLang()
        {
            this.Dict.Add("SALUDO", "Hello");
            this.Dict.Add("DESPEDIDA", "Goodbye");
        }
    }

    class Dt : Lang
    {
        public override void configLang()
        {
            this.Dict.Add("SALUDO", "Hallo");
            this.Dict.Add("DESPEDIDA", "Guten Tag");
        }
    }

    class LangInterface {
        public Lang lang;

        public LangInterface(Lang idioma) {
            this.lang = idioma;
            this.lang.configLang();
        }

        public Dictionary<string, string> GetDict() {
            return this.lang.Dict;
        }

        public string Get(string key) {
            return this.lang.Dict[key];
        }
    }

}
