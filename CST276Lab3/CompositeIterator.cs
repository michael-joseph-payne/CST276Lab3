using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    public class Iterator
    {
        public static GuitarComponent next()
        {
            //Need to implement
            return null;
        }
    }

    public class CompositeIterator : Iterator
    {
        Stack<CompositeIterator> stack = new Stack<CompositeIterator>();
   
        public CompositeIterator(CompositeIterator iterator)
        {
            stack.Push(iterator);
        }
   
        public new Object next()
        {
            if (hasNext())
            {
                Iterator iterator = (Iterator) stack.Peek();
                GuitarComponent component = (GuitarComponent) Iterator.next();
                stack.Push(null/*component.createIterator()*/);
                return component;
            }
            else
            {
                return null;
            }
    }
  
    public bool hasNext()
    {
        if (stack.Count == 0)
        {
            return false;
        }
        else
        {
            Iterator iterator = (Iterator) stack.Peek();
            if (!hasNext())
            {
                stack.Pop();
                return hasNext();
            }
            else
            {
                return true;
            }
        }
    }
   
    public void remove()
    {
        throw new NotImplementedException();
    }
}
}
