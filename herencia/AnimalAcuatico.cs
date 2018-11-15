using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    //Con esto automaticamente animalAcuatico ya puede comer y puede tener un nombre(las variables de animal)
    public class AnimalAcuatico : Animal
    {
        public void Nadar()
        {
            Console.WriteLine("Hola soy un " + Nombre + " y estoy nadando");
        }
    }
}
