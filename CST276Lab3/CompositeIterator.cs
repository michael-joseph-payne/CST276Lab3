using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CST276Lab3
{
    //Simple iterator interface to inherit from
    public interface Iterator
    {
        //Function to check whether there is a next element
        bool hasNext();
        //Function to return the next object
        Object next();
    }

    //Null iterator implementation for composite leaf objects
    public class NullIterator : Iterator
    {
        //Always returns false, as a null iterator should
        public bool hasNext()
        {
            return false;
        }
        //Always returns null, as a null iterator should
        public Object next()
        {
            return null;
        }
    }

    //Composite iterator implementation
    public class CompositeIterator : Iterator
    {
        //Stack object to hold iterators (unwind to iterate through the composite tree)
        Stack<Iterator> stack = new Stack<Iterator>();
        
        //Default constructor - pushes the base iterator object onto the stack
        public CompositeIterator(Iterator iterator)
        {
            stack.Push(iterator);
        }
        //Implementation of the hasNext() function - returns the next iterator on the stack (if it exists)
        public Object next()
        {
            //If another iterator is on the stack
            if (hasNext())
            {
                //Grab a copy of the object by peeking
                Iterator iterator = (Iterator) stack.Peek();
                //Check to see if it has a 'child' iterator
                GuitarComponent component = (GuitarComponent) iterator.next();
                //If the 'child' object is of type component, it has children we must create iterators for
                if (component is GuitarComponent)
                {
                    stack.Push(component.createIterator());
                } 
                return component;
            }
            //If another iterator is NOT on the stack
            else
            {
                return null;
            }
        }
        //Implementation of the next() function - returns false if another iterator exists on the stack
        public bool hasNext()
        {
            //If there's nothing on the stack, return false
            if (stack.Count == 0)
            {
                return false;
            }
            //If another iterator is sitting on the stack
            else
            {
                //Peek at it
                Iterator iterator = (Iterator)stack.Peek();
                //If it doesn't have anything below it, pop the stack and return false
                if (!iterator.hasNext())
                {
                    stack.Pop();
                    return hasNext();
                }
                //Otherwise return true
                else
                {
                    return true;
                }
            }
        }
    }
    //Guitar component iterator implementation
    public class GuitarComponentIterator : Iterator
    {
        //Array to hold the nodes/leaves associated with the component
        GuitarComponent[] items;
        //Start at default position of items[0]
        int position = 0;

        //Public constructor, takes an array of GuitarComponent objects as an argument
        public GuitarComponentIterator(GuitarComponent[] items)
        {
            this.items = items;
        }
        //Simple next() function that returns the next item in the array
        public Object next()
        {
            GuitarComponent guitarItem = items[position];
            position = position + 1;
            return guitarItem;
        }
        //Simple hasNext() function to determine if there is an item in items[position + 1]
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
}
