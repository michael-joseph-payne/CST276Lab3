using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    public abstract class GuitarComponent
    {
        public void add(GuitarComponent guitarComponent)
        {
            throw new NotImplementedException();
        }
        public abstract Iterator createIterator();
        public abstract String getDescription();
        public abstract void assemble();
    }

    public abstract class GuitarItem : GuitarComponent
    {
        public override Iterator createIterator()
        {
            return new NullIterator();
        }
        public override abstract String getDescription();
        public override abstract void assemble();
    }

    public class TuningAssembly : GuitarComponent
    {
        List<GuitarComponent> itemList = new List<GuitarComponent>();
        String description = "Tuning Assembly";

        public TuningAssembly()
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

        public new void add(GuitarComponent guitarComponent)
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
}
