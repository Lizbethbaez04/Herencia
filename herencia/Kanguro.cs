using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    public class Kanguro : AnimalTerrestre
    {
        public Kanguro()
        {
            Nombre = "Kanguro";
        }
        public void SaltarBienAlto()
        {
            Console.WriteLine("Hola soy un " + Nombre + " y estoy saltando alto");
        }
    }
}
