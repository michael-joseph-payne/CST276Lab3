using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    class Robot1
    {
        GuitarComponent whatToAssemble;
        CompositeIterator compositeIterator;

        public Robot1(GuitarComponent whatToAssemble)
        {
            this.whatToAssemble = whatToAssemble;
            this.compositeIterator = new CompositeIterator(whatToAssemble.createIterator());
        }

        public void assemble()
        {
            whatToAssemble.assemble();
            while (compositeIterator.hasNext())
            {
                GuitarComponent guitarComponent = (GuitarComponent)compositeIterator.next();
                try
                {
                    guitarComponent.assemble();
                }
                catch
                {
                    Console.WriteLine("Exception");
                }
            }
        }
    }
}
