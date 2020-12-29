using System;
using System.Collections.Generic;

namespace net
{
    // Patron Composite
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ElementoConHijos raiz = new ElementoConHijos();
            raiz.Tag = "html";

            ElementoConHijos boton = new ElementoConHijos();
            boton.Tag = "button";

            raiz.Children.Add(boton);

            raiz.Mostrar();
            */

            Paso salir = new AccionFinal(() => {
                Console.WriteLine("Estoy saliendooooo");
            });

            Paso llueve = new Decision(() =>{
                Console.WriteLine("¿Como esta el clima? 1 = llueve / 2 = no llueve");
                string val = Console.ReadLine();
                return val == "2";
            }, salir);

            Paso salirCalle = new Decision(() => {
                Console.WriteLine("Encontrando las llaves....");
                return true;
            }, llueve);

            salirCalle.eval();

        }
    }

    abstract class Paso {

        public string Type {get; set;}
        public abstract void eval();
        public abstract void perform();

    }

    class Decision : Paso {

        private Paso next;
        private Func<bool> procesoDecision;

        public Decision(Func<bool> procesoDecision, Paso siguiente) : base() {
            this.next = siguiente;
            this.procesoDecision = procesoDecision;
            this.Type = "decision";
        }

        public override void eval()
        {
            bool val = this.procesoDecision.Invoke();

            Console.WriteLine(val);

            if(val) {
                if(this.next.Type == "decision") {
                    this.next.eval();
                } else {
                    this.next.perform();
                }
            }
        }

        public override void perform()
        {
        }

    }

    class AccionFinal : Paso {
        private Action action;

        public AccionFinal(Action action) : base() {
            this.action = action;
        }

        public override void perform()
        {
            this.action();
        }

        public override void eval()
        {
        }
    }

    /*
    class Elemento { 
        public string Type {get; set;}

        public string Content {get; set;}

        public List<Elemento> Children {get; set;}

        public string Tag {get; set;}

        public Elemento() {
            this.Children = new List<Elemento>();
        }

        public virtual void Mostrar() {}
    }

    class ElementoConHijos : Elemento {

        public ElementoConHijos() { this.Type = "con_hijos"; }

        public override void Mostrar() {
            Console.WriteLine("Mostrando "+this.Tag);
            this.Children.ForEach(el => {
                if(el.Type == "con_hijos") {
                    Console.WriteLine("Mostrando "+el.Tag);
                    el.Mostrar();
                } else {
                    Console.WriteLine("Mostrando "+el.Content);
                }
            });
        }

    }

    class ElementoFinal : Elemento {
        public ElementoFinal() { this.Type = "final"; }
    }

    */

}
