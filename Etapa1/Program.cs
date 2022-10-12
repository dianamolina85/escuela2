using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace CoreEscuela
{
  class Program
    {


        static void Main(string[] args)
        {            
            var engine = new EscuelaEngine();
            engine.Inicializar();  
            Printer.WriteTitle("Bienvenidos a la Escuela");
            Printer.Beep(10000, cant:10);
            ImprimirCursosEscuela(engine.Escuela);

        }
              
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos Disponibles");
                     
                foreach (var curso in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniId}");
                }
                       
        }


    }
}
