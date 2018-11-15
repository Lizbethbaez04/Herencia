using System;
using System.Collections.Generic;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            AnimalTerrestre elefante = new AnimalTerrestre();
            Kanguro kanguro = new Kanguro();

            List<Animal> animales = new List<Animal>();

            Animal tiburon = new AnimalAcuatico();
            tiburon.Nombre = "Tiburon";
            //el tiburon no puede dar porque se esta tratando como un animal y no como un animal acuatico
            //tiburon.Nadar(); a menos que... POLIMORFISMO
            ((AnimalAcuatico)tiburon).Nadar();

            delfin.Nombre = "Delfin";
            elefante.Nombre = "Elefante";

            delfin.Comer();
            delfin.Nadar();

            elefante.Caminar();

            kanguro.Caminar();
            kanguro.SaltarBienAlto();
            kanguro.Comer();

            animales.Add(delfin);
            animales.Add(tiburon);
            animales.Add(elefante);
            animales.Add(kanguro);

            foreach(var animal in animales)
            {
                Console.WriteLine(animal.Nombre);
                if(animal.GetType()== typeof(AnimalAcuatico))
                {
                    ((AnimalAcuatico)animal).Nadar();
                }
                
            }

            Console.ReadLine();
        }
    }
}
