using System;
using System.Collections.Generic;

namespace COR_Alumnos
{
    class Inicio
    {
        public void Main()
        {
            EstadoAlumno sobresaliente = new EstadoSobresaliente();
            EstadoAlumno excelente = new EstadoExcelente();
            EstadoAlumno bueno = new EstadoBueno();
            EstadoAlumno regular = new EstadoRegular();
            EstadoAlumno insuficiente = new EstadoInsuficiente();

            bueno
                .SetSiguenteEstado(insuficiente)
                .SetSiguenteEstado(sobresaliente)
                .SetSiguenteEstado(excelente)
                .SetSiguenteEstado(regular);

            List<Alumno> notasDiciembre = new List<Alumno>();

            notasDiciembre.Add(new Alumno("Carlos Lopez", 10));
            notasDiciembre.Add(new Alumno("Andrea Perez", 1)); 
            notasDiciembre.Add(new Alumno("Camila Palladino", 2)); 
            notasDiciembre.Add(new Alumno("Gabriel Berger", 5)); 
            notasDiciembre.Add(new Alumno("Josefina Lopez Quintas", 7)); 
            notasDiciembre.Add(new Alumno("Alberto Kristof", 6)); 
            notasDiciembre.Add(new Alumno("Ramon Calvin", 8)); 

            notasDiciembre.ForEach(alumno =>
            {
                bueno.EvaluarEstado(alumno);
            });

        }
    }

    class Alumno
    {
        public string nombre { get; set; }
        public int nota { get; set; }

        public Alumno(string nombre, int nota)
        {
            this.nombre = nombre;
            this.nota = nota;
        }
    }


    abstract class EstadoAlumno
    {

        protected EstadoAlumno SiguienteEstado;

        public EstadoAlumno SetSiguenteEstado(EstadoAlumno next)
        {
            this.SiguienteEstado = next;
            return next;
        }

        public abstract void EvaluarEstado(Alumno alumno);

    }

    /***
    Sobresaliente: 10
    Excelentes: 9 u 8
    Buenos: 7 o 6
    Regulares: 5 o 4
    Insuficiente: 3, 2 o 1
    */
    class EstadoSobresaliente : EstadoAlumno
    {
        public override void EvaluarEstado(Alumno alumno)
        {
            if (alumno.nota == 10)
            {
                Console.WriteLine("Felicidades {0}! Eres sobresaliente", alumno.nombre);
            }
            else if (this.SiguienteEstado != null)
            {
                this.SiguienteEstado.EvaluarEstado(alumno);
            }
        }
    }

    class EstadoExcelente : EstadoAlumno
    {
        public override void EvaluarEstado(Alumno alumno)
        {
            if (alumno.nota == 9 || alumno.nota == 8)
            {
                Console.WriteLine("Muy bien {0}! Eres excelente", alumno.nombre);
            }
            else if (this.SiguienteEstado != null)
            {
                this.SiguienteEstado.EvaluarEstado(alumno);
            }
        }
    }

    class EstadoBueno : EstadoAlumno
    {
        public override void EvaluarEstado(Alumno alumno)
        {
            if (alumno.nota == 7 || alumno.nota == 6)
            {
                Console.WriteLine("Vas bien {0}! Eres bueno", alumno.nombre);
            }
            else if (this.SiguienteEstado != null)
            {
                this.SiguienteEstado.EvaluarEstado(alumno);
            }
        }
    }

    class EstadoRegular : EstadoAlumno
    {
        public override void EvaluarEstado(Alumno alumno)
        {
            if (alumno.nota == 5 || alumno.nota == 4)
            {
                Console.WriteLine("Hay que estudiar más {0}! Eres regular", alumno.nombre);
            }
            else if (this.SiguienteEstado != null)
            {
                this.SiguienteEstado.EvaluarEstado(alumno);
            }
        }
    }

    class EstadoInsuficiente : EstadoAlumno
    {
        public override void EvaluarEstado(Alumno alumno)
        {
            if (alumno.nota >= 1 && alumno.nota <= 3)
            {
                Console.WriteLine("No has alcanzado lo que se esperaba {0}! Intenta de nuevo", alumno.nombre);
            }
            else if (this.SiguienteEstado != null)
            {
                this.SiguienteEstado.EvaluarEstado(alumno);
            }
        }
    }
}
