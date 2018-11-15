using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    public class Animal
    {
        public string Nombre { get; set; }

        public void Comer()
        {
            Console.WriteLine("Hola soy un " + Nombre + " y estoy comiendo");
        }
    }
}
