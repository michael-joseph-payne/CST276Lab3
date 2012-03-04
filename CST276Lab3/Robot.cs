using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    class Robot
    {
        String whichRobot;
        GuitarComponent whatToAssemble;
        CompositeIterator compositeIterator;

        public Robot(String whichRobot, GuitarComponent whatToAssemble)
        {
            this.whichRobot = whichRobot;
            this.whatToAssemble = whatToAssemble;
            this.compositeIterator = new CompositeIterator(whatToAssemble.createIterator());
        }

        public void setWhatToAssemble(GuitarComponent whatToAssemble)
        {
            this.whatToAssemble = whatToAssemble;
            this.compositeIterator = new CompositeIterator(whatToAssemble.createIterator());
        }

        public String whatAmIAssembling()
        {
            return whatToAssemble.getDescription();
        }

        public void assemble()
        {
            Console.WriteLine(whichRobot + " - Assembling " + whatToAssemble.getDescription());
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
