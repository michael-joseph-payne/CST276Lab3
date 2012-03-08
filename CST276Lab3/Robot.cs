using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    //Simple class to house a robot object
    //Did not build as an interface, as all robots do the same tasks (only the behavior changes, set through an accessor function)
    class Robot
    {
        //String description of what robot
        String whichRobot;
        //Node related to what branch of the guitar tree we're building
        GuitarComponent whatToAssemble;
        //Composite iterator associated with the branch of the guitar tree we're building
        CompositeIterator compositeIterator;

        //Public constructor, names the robot and tells it what to assemble
        public Robot(String whichRobot, GuitarComponent whatToAssemble)
        {
            this.whichRobot = whichRobot;
            this.whatToAssemble = whatToAssemble;
            this.compositeIterator = new CompositeIterator(whatToAssemble.createIterator());
        }

        //Accessor function to set what the robot will construct
        public void setWhatToAssemble(GuitarComponent whatToAssemble)
        {
            this.whatToAssemble = whatToAssemble;
            this.compositeIterator = new CompositeIterator(whatToAssemble.createIterator());
        }

        //Accessor function that returns the name of the robot
        public String whatAmIAssembling()
        {
            return whatToAssemble.getDescription();
        }

        //'Assembles' the guitar component (outputs the steps to standard out)
        public void assemble()
        {
            Console.WriteLine(whichRobot + " - Assembling " + whatToAssemble.getDescription());
            //Write to console what I'm building
            whatToAssemble.assemble();
            //Steps through the node's children and 'assemble' them too
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
