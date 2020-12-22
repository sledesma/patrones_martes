using System;

namespace eventos_net
{
    class Program
    {
        static void Main(string[] args)
        {
            Observador obs = new Observador(new SujetoAction());

            Sujeto suj1 = new Sujeto(obs);

            suj1.notificar();
           
        }
    }

    // Eventos
    /// Observador

    class Observador {

        private IAction action;
        public Observador(IAction action) {
            this.action = action;
        }

        public void saludar() {
            action.invoke();
        }

    }

    class Sujeto {

        private Observador observer;
        public Sujeto(Observador obs) {
            this.observer = obs;
        }

        public void notificar() {
            this.observer.saludar();
        }
    }

    interface IAction {
        public void invoke();
    }

    class SujetoAction : IAction
    {
        public void invoke()
        {
            Console.Write("Hola mundo desde la accion del sujeto");
        }
    }
}
