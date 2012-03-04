using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    class Program
    {
        enum which { Robot1, Robot2, Robot3 };
        enum whatAreWeDoing { PickRobot, PickProduct, AssembleProduct, AskIfQuit, WantToQuit };

        static void Main(string[] args)
        {
            which whichOne = which.Robot1;
            whatAreWeDoing step = whatAreWeDoing.PickRobot;
            Robot robot1 = new Robot("Robot 1", new ElectricGuitar());
            Robot robot2 = new Robot("Robot 2", new ElectricGuitar());
            Robot robot3 = new Robot("Robot 3", new ElectricGuitar());
            while (step != whatAreWeDoing.WantToQuit)
            {
                switch (step)
                {
                    case whatAreWeDoing.PickRobot:
                        Console.WriteLine("Which robot would you like to assemble something? (1/2/3)");
                        String whichRobot = Console.ReadLine();
                        switch (whichRobot)
                        {
                            case "1":
                                whichOne = which.Robot1;
                                Console.WriteLine("Robot 1 selected.");
                                break;
                            case "2":
                                whichOne = which.Robot2;
                                Console.WriteLine("Robot 2 selected.");
                                break;
                            case "3":
                                whichOne = which.Robot3;
                                Console.WriteLine("Robot 3 selected.");
                                break;
                            default:
                                whichOne = which.Robot1;
                                Console.WriteLine("I did not understand your selection, so Robot 1 was picked by default.");
                                break;
                        }
                        step = whatAreWeDoing.PickProduct;
                        break;
                    case whatAreWeDoing.PickProduct:
                        Console.WriteLine("Picking a product");
                        step = whatAreWeDoing.AssembleProduct;
                        break;
                    case whatAreWeDoing.AssembleProduct:
                        switch (whichOne)
                        {
                            case which.Robot1:
                                robot1.assemble();
                                break;
                            case which.Robot2:
                                robot2.assemble();
                                break;
                            case which.Robot3:
                                robot3.assemble();
                                break;
                            default:
                                Console.WriteLine("Error selecting which robot to assemble.");
                                break;
                        }
                        step = whatAreWeDoing.AskIfQuit;
                        break;
                    case whatAreWeDoing.AskIfQuit:
                        Console.WriteLine("Are you done? (y/n)");
                        String quit = Console.ReadLine();
                        if (quit == "y")
                        {
                            step = whatAreWeDoing.WantToQuit;
                        }
                        else
                        {
                            step = whatAreWeDoing.PickRobot;
                        }
                        break;
                    default:
                        step = whatAreWeDoing.WantToQuit;
                        break;
                }
            }
        }
    }
}
