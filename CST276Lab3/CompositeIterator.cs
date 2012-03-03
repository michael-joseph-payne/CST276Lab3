using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }

    public class NullIterator : Iterator
    {
        public bool hasNext()
        {
            return false;
        }
        public Object next()
        {
            return null;
        }
    }

    public class GuitarComponentIterator : Iterator
    {
        GuitarComponent[] items;
        int position = 0;

        public GuitarComponentIterator(GuitarComponent[] items)
        {
            this.items = items;
        }
        public Object next()
        {
            GuitarComponent guitarItem = items[position];
            position = position + 1;
            return guitarItem;
        }
        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class CompositeIterator : Iterator
    {
        Stack<Iterator> stack = new Stack<Iterator>();
   
        public CompositeIterator(Iterator iterator)
        {
            stack.Push(iterator);
        }

        public Object next()
        {
            if (hasNext())
            {
                Iterator iterator = (Iterator) stack.Peek();
                GuitarComponent component = (GuitarComponent) iterator.next();
                if (component is GuitarComponent)
                {
                    stack.Push(component.createIterator());
                } 
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
                Iterator iterator = (Iterator)stack.Peek();
                if (!iterator.hasNext())
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
    }
}
