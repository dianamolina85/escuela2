using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();

        string nombre;
        public string Nombre { get { return "Copia:"+nombre; } set { nombre = value.ToUpper(); } }
        public int añoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela tipoEscuela{ get; set; }

        
       
       
        public List<Curso> Cursos{ get; set; }
        public Escuela(string nombre, int año) => (Nombre, añoDeCreacion) = (nombre, año);

        public Escuela(string nombre, int año,
                       TiposEscuela tipo,
                       string pais = "", string ciudad = "") : base()
        {
            (Nombre, añoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {tipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }
}
