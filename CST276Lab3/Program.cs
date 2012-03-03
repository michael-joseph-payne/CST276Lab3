using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            GuitarComponent electricGuitar = new ElectricGuitar();
            electricGuitar.add(new ElectricComponents());
            CompositeIterator tuningAssemblyIterator = new CompositeIterator(electricGuitar.createIterator());
            electricGuitar.assemble();
            while (tuningAssemblyIterator.hasNext())
            {
                GuitarComponent guitarComponent = (GuitarComponent) tuningAssemblyIterator.next();
                try
                {
                    guitarComponent.assemble();
                }
                catch
                {
                    Console.WriteLine("Exception");
                }
            }
            Console.ReadLine();
        }
    }
}
