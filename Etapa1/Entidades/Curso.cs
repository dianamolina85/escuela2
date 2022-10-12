using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }

        public string UniId { get; private set; } = Guid.NewGuid().ToString();
        public TipoJornada jornada { get; set;}

        public List<Asignatura> Asignaturas { get; set; }
        public List<Estudiante> Estudiante { get; set; }
        
    }

}
