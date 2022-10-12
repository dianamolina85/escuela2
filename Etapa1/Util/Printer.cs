using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CoreEscuela.Util
{
    // Auxiliar de impresion
    public static  class Printer
    {
        public static void DrawLine(int linesize=10) 
        {
            WriteLine("".PadLeft(linesize, '=' ));
            
        }

        public static void WriteTitle(string title)
        {
            DrawLine(title.Length +4);
            WriteLine($"| {title} |");
            DrawLine(title.Length +4);
        }

        public static void Beep(int hz=2000, int tiempo=500, int cant=1) 
        {
            while (cant-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }

    }
}
