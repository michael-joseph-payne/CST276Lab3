using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    class Program
    {
        enum whichRobot { Robot1, Robot2, Robot3 };
        enum whatAreWeDoing { PickRobot, PickProduct, AssembleProduct, AskIfQuit, WantToQuit };
        enum whatAreWeBuilding { ElectricGuitar, AcousticGuitar, Fretboard, Head, Neck, ElectricBody, AcousticBody, ElectricTuningAssembly, AcousticTuningAssembly, ElectricComponents, FinishHardware };

        static void Main(string[] args)
        {
            whichRobot activeRobot = whichRobot.Robot1;
            whatAreWeDoing activeState = whatAreWeDoing.PickRobot;

            Robot robot1 = new Robot("Robot 1", new ElectricGuitar());
            Robot robot2 = new Robot("Robot 2", new ElectricGuitar());
            Robot robot3 = new Robot("Robot 3", new ElectricGuitar());
            while (activeState != whatAreWeDoing.WantToQuit)
            {
                switch (activeState)
                {
                    case whatAreWeDoing.PickRobot:
                        Console.WriteLine("Which robot would you like to assemble something? (1/2/3)");
                        String choiceOfRobot = Console.ReadLine();
                        switch (choiceOfRobot)
                        {
                            case "1":
                                activeRobot = whichRobot.Robot1;
                                Console.WriteLine("Robot 1 selected.");
                                break;
                            case "2":
                                activeRobot = whichRobot.Robot2;
                                Console.WriteLine("Robot 2 selected.");
                                break;
                            case "3":
                                activeRobot = whichRobot.Robot3;
                                Console.WriteLine("Robot 3 selected.");
                                break;
                            default:
                                activeRobot = whichRobot.Robot1;
                                Console.WriteLine("I did not understand your selection, so Robot 1 was picked by default.");
                                break;
                        }
                        activeState = whatAreWeDoing.PickProduct;
                        break;
                    case whatAreWeDoing.PickProduct:
                        Console.WriteLine("Picking a product to build:");
                        Console.WriteLine("1)  Electric Guitar");
                        Console.WriteLine("2)  Acoustic Guitar");
                        Console.WriteLine("3)  Fretboard");
                        Console.WriteLine("4)  Head");
                        Console.WriteLine("5)  Neck");
                        Console.WriteLine("6)  Electric Body");
                        Console.WriteLine("7)  Acoustic Body");
                        Console.WriteLine("8)  Electric Tuning Assembly");
                        Console.WriteLine("9)  Acoustic Tuning Assembly");
                        Console.WriteLine("10) Electric Components");
                        Console.WriteLine("11) Finish Hardware");
                        String choiceOfProduct = Console.ReadLine();
                        switch (choiceOfProduct)
                        {
                            case "1":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new ElectricGuitar());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new ElectricGuitar());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new ElectricGuitar());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "2":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new AcousticGuitar());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new AcousticGuitar());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new AcousticGuitar());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "3":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new FretBoard());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new FretBoard());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new FretBoard());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "4":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new Head());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new Head());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new Head());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "5":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new Neck());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new Neck());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new Neck());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "6":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new ElectricBody());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new ElectricBody());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new ElectricBody());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "7":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new AcousticBody());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new AcousticBody());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new AcousticBody());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "8":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new ElectricTuningAssembly());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new ElectricTuningAssembly());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new ElectricTuningAssembly());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "9":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new AcousticTuningAssembly());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new AcousticTuningAssembly());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new AcousticTuningAssembly());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "10":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new ElectricComponents());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new ElectricComponents());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new ElectricComponents());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            case "11":
                                switch (activeRobot)
                                {
                                    case whichRobot.Robot1:
                                        robot1.setWhatToAssemble(new FinishHardware());
                                        break;
                                    case whichRobot.Robot2:
                                        robot2.setWhatToAssemble(new FinishHardware());
                                        break;
                                    case whichRobot.Robot3:
                                        robot3.setWhatToAssemble(new FinishHardware());
                                        break;
                                    default:
                                        Console.WriteLine("Error setting product type.");
                                        break;
                                }
                                activeState = whatAreWeDoing.AssembleProduct;
                                break;
                            default:
                                Console.WriteLine("That was not a valid product.");
                                break;
                        }
                        break;
                    case whatAreWeDoing.AssembleProduct:
                        switch (activeRobot)
                        {
                            case whichRobot.Robot1:
                                robot1.assemble();
                                break;
                            case whichRobot.Robot2:
                                robot2.assemble();
                                break;
                            case whichRobot.Robot3:
                                robot3.assemble();
                                break;
                            default:
                                Console.WriteLine("Error selecting which robot to assemble.");
                                break;
                        }
                        activeState = whatAreWeDoing.AskIfQuit;
                        break;
                    case whatAreWeDoing.AskIfQuit:
                        Console.WriteLine("Are you done? (y/n)");
                        String quit = Console.ReadLine();
                        if (quit == "y")
                        {
                            activeState = whatAreWeDoing.WantToQuit;
                        }
                        else
                        {
                            activeState = whatAreWeDoing.PickRobot;
                        }
                        break;
                    default:
                        activeState = whatAreWeDoing.WantToQuit;
                        break;
                }
            }
        }
    }
}
