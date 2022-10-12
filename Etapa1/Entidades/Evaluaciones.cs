using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniId { get; private set; }
        public string Nombre { get; set; }
        public Estudiante  Estudiante { get; set; }
        public Asignatura asignatura { get; set; }

        public float Note { get; set; }
        public Evaluaciones()
        {
            UniId = Guid.NewGuid().ToString();
        }
    }
}
