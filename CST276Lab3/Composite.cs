using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    public abstract class GuitarComponent
    {
        List<GuitarComponent> jobQueue = new List<GuitarComponent>();

        public void add(GuitarComponent guitarComponent)
        {
            jobQueue.Add(guitarComponent);
        }
        public void remove(GuitarComponent guitarComponent)
        {
            jobQueue.Remove(guitarComponent);
        }
        public GuitarComponent getChild(int i)
        {
            //Need to implement with iterator
            return null;
        }
        public abstract String getDescription();
        public abstract void assemble();
    }

    public abstract class GuitarItem : GuitarComponent
    {
        public override abstract String getDescription();
        public override abstract void assemble();
    }

    public class TuningAssembly : GuitarComponent
    {
        String description = "Tuning Assembly";

        public TuningAssembly()
        {
            base.add(new LowEStringPeg());
            base.add(new AStringPeg());
            base.add(new DStringPeg());
            base.add(new GStringPeg());
            base.add(new BStringPeg());
            base.add(new HighEStringPeg());

            base.add(new InotationAdjust());

            base.add(new LowEString());
            base.add(new AString());
            base.add(new DString());
            base.add(new GString());
            base.add(new BString());
            base.add(new HighEString());

            base.add(new WhammyBar());
        }
        public override String getDescription()
        {
            return description;
        }
        public override void assemble()
        {
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
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
            Console.Write(description);
        }
    }
}
