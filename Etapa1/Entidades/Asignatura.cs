using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string UniId { get; private set; }
        public string Nombre { get; set; }

        public Asignatura()
        {
            UniId = Guid.NewGuid().ToString();
        }
    }
}
