using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    public abstract class GuitarComponent
    {
        public abstract void add(GuitarComponent guitarComponent);
        public abstract Iterator createIterator();
        public abstract String getDescription();
        public abstract void assemble();
    }

    public class ElectricGuitar : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Electric Guitar";

        public ElectricGuitar()
        {
            add(new ElectricBody());
            add(new Neck());
            add(new Head());
            add(new ElectricComponents());
            add(new FinishHardware());
            add(new ElectricTuningAssembly());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class AcousticGuitar : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Acoustic Guitar";

        public AcousticGuitar()
        {
            add(new AcousticBody());
            add(new Neck());
            add(new Head());
            add(new FinishHardware());
            add(new AcousticTuningAssembly());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class FretBoard : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Fret Board";

        public FretBoard()
        {
            add(new Rosewood());
            add(new Frets());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class Head : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Head";

        public Head()
        {
            add(new Maple());
            add(new ClearCoat());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class Neck : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Neck";

        public Neck()
        {
            add(new Maple());
            add(new ClearCoat());
            add(new FretBoard());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class ElectricBody : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Electric Body";

        public ElectricBody()
        {
            add(new Maple());
            add(new Paint());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class AcousticBody : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Acoustic Body";

        public AcousticBody()
        {
            add(new Spruce());
            add(new ClearCoat());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class ElectricTuningAssembly : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Electric Tuning Assembly";

        public ElectricTuningAssembly()
        {
            add(new LowEStringPeg());
            add(new AStringPeg());
            add(new DStringPeg());
            add(new GStringPeg());
            add(new BStringPeg());
            add(new HighEStringPeg());

            add(new InotationAdjust());

            add(new LowEString());
            add(new AString());
            add(new DString());
            add(new GString());
            add(new BString());
            add(new HighEString());

            add(new WhammyBar());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class AcousticTuningAssembly : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Acoustic Tuning Assembly";

        public AcousticTuningAssembly()
        {
            add(new LowEStringPeg());
            add(new AStringPeg());
            add(new DStringPeg());
            add(new GStringPeg());
            add(new BStringPeg());
            add(new HighEStringPeg());

            add(new LowEString());
            add(new AString());
            add(new DString());
            add(new GString());
            add(new BString());
            add(new HighEString());

            add(new Saddle());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class ElectricComponents : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Electronic Components";

        public ElectricComponents()
        {
            add(new OutputJack());
            add(new Pickups());
            add(new SelectorSwitch());
            add(new ToneKnob());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }
    public class FinishHardware : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Finish Hardware";

        public FinishHardware()
        {
            add(new ScratchPlate());
            add(new StrapButtons());
        }

        public override void add(GuitarComponent guitarComponent)
        {
            itemList.Add(guitarComponent);
        }
        public override Iterator createIterator()
        {
            return new GuitarComponentIterator(itemList.ToArray());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("Assembling " + description);
        }
    }

    public abstract class GuitarItem : GuitarComponent
    {
        public override void add(GuitarComponent guitarComponent)
        {
            throw new NotImplementedException();
        }
        public override Iterator createIterator()
        {
            return new NullIterator();
        }
        public override abstract String getDescription();
        public override abstract void assemble();
    }

    public class LowEStringPeg : GuitarItem
    {
        String description = "Low E String Peg";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class AStringPeg : GuitarItem
    {
        String description = "A String Peg";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class DStringPeg : GuitarItem
    {
        String description = "D String Peg";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class GStringPeg : GuitarItem
    {
        String description = "G String Peg";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class BStringPeg : GuitarItem
    {
        String description = "B String Peg";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class HighEStringPeg : GuitarItem
    {
        String description = "High E String Peg";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class InotationAdjust : GuitarItem
    {
        String description = "Inotation Adjust";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class LowEString : GuitarItem
    {
        String description = "Low E String";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class AString : GuitarItem
    {
        String description = "A String";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class DString : GuitarItem
    {
        String description = "D String";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class GString : GuitarItem
    {
        String description = "G String";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class BString : GuitarItem
    {
        String description = "B String";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class HighEString : GuitarItem
    {
        String description = "High E String";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class WhammyBar : GuitarItem
    {
        String description = "Whammy Bar";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class OutputJack : GuitarItem
    {
        String description = "Output Jack";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class Pickups : GuitarItem
    {
        String description = "Pickups";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class SelectorSwitch : GuitarItem
    {
        String description = "Selector Switch";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class ToneKnob : GuitarItem
    {
        String description = "Tone Knob";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class ScratchPlate : GuitarItem
    {
        String description = "Scratch Plate";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class Saddle : GuitarItem
    {
        String description = "Saddle";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class StrapButtons : GuitarItem
    {
        String description = "Strap Buttons";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class Frets : GuitarItem
    {
        String description = "Frets";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tPlacing " + description);
        }
    }
    public class Rosewood : GuitarItem
    {
        String description = "Rosewood";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tCarving " + description);
        }
    }
    public class Maple : GuitarItem
    {
        String description = "Maple";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tCarving " + description);
        }
    }
    public class Spruce : GuitarItem
    {
        String description = "Spruce";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tCarving " + description);
        }
    }
    public class Paint : GuitarItem
    {
        String description = "Paint";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tAdding " + description);
        }
    }
    public class ClearCoat : GuitarItem
    {
        String description = "Clear Coat";

        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.WriteLine("\tAdding " + description);
        }
    }
}
