﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot1 robot = new Robot1(new ElectricGuitar());
            robot.assemble();
            robot.setWhatToAssemble(new AcousticGuitar());
            robot.assemble();
            robot.setWhatToAssemble(new AcousticTuningAssembly());
            robot.assemble();
            Console.ReadLine();
        }
    }
}
