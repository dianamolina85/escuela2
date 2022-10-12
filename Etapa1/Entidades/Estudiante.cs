using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public class Estudiante
    {
        public string UniId { get; private set; }
        public string Nombre { get; set; }

        public Estudiante()
        {
            UniId = Guid.NewGuid().ToString();
        }
    }
}
