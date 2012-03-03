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
            TuningAssembly tuningAssembly = new TuningAssembly();
            CompositeIterator tuningAssemblyIterator = new CompositeIterator(tuningAssembly.createIterator());
            tuningAssembly.assemble();
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
