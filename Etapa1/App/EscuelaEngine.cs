using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
                        
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, pais: "Colombia",
                ciudad: "Ibague"
                );
          CargarCursos();
          CargarAsignaturas();
          CargarEvaluaciones();


        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
           
            foreach (var curso in Escuela.Cursos) 
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre="Matematicas"},
                    new Asignatura{Nombre="Educacion Fisica"},
                    new Asignatura{Nombre="Castellano"},
                    new Asignatura{Nombre="Ciencias naturales"},
                };

                curso.Asignaturas =listaAsignaturas;
            }

         
        }

        private List<Estudiante> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaEstudiante = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Estudiante { Nombre = $"{n1} {n2} {a1}" };

            return listaEstudiante.OrderBy((al) => al.UniId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", jornada = TipoJornada.Mañana },
                        new Curso() {Nombre = "201", jornada = TipoJornada.Mañana},
                        new Curso{Nombre = "301", jornada = TipoJornada.Mañana},
                        new Curso(){ Nombre = "401", jornada = TipoJornada.Tarde },
                        new Curso() {Nombre = "501", jornada = TipoJornada.Tarde},
            };

            Random rnd = new Random();
            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Estudiante = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}
