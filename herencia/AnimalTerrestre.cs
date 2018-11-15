using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    public class AnimalTerrestre : Animal
    {
        public void Caminar()
        {
            Console.WriteLine("Hola soy un " + Nombre + " y estoy caminando");
        }
    }
}
