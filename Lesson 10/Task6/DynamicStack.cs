using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    /// <summary>
    /// Represents dynamic list implementation
    /// </summary>
    public class DynamicStack
    {
        private class Node
        {
            private object element;
            private Node previos;
            public object Element
            {
                get { return element; }
                set { element = value; }
            }
            public Node Previos
            {
                get { return previos; }
                set { previos = value; }
            }
            public Node(object element, Node prevNode)
            {
                this.element = element;
                this.Previos = prevNode;

            }
            public Node(object element)
            {
                this.element = element;
                previos = null;
            }
        }
        private Node top;
        private int count;

        /// <summary>
        /// Constructor
        /// </summary>
        public DynamicStack()
        {
            this.top = null;
            this.count = 0;
        }

        /// <summary>
        /// Add element at the top of the stack
        /// </summary>
        /// <param name="item">The element you want to add</param>
        public void Push(object item)
        {
            if (top == null)
            {
                top = new Node(item);
            }
            else
            {
                Node newNode = new Node(item, top);
                top = newNode;
            }
            count++;
        }

        /// <summary>
        /// Removes and returns the object at the top of the stack
        /// </summary>
        /// <returns> The element you want to get </returns>
        public object Pop()
        {
            object item;
            if (top == null)
            {
                throw new NullReferenceException("The stack is empty.");
            }
            else
            {
                item = top.Element;
                top = top.Previos;
                count--;
                return item;
            }
        }

        /// <summary>
        /// Returns the object at the top of the stack without removes it.
        /// </summary>
        /// <returns> The element you want to get </returns>
        public object Peek()
        {
            object item;
            if (top == null)
            {
                throw new NullReferenceException("The stack is empty.");
            }
            else
            {
                item = top.Element;
                return item;
            }
        }

        /// <summary>
        /// Clear all elements from the stack
        /// </summary>
        public void Clear()
        {
            if (top != null)
            {
                object item; 
                for (int i = 0; i < this.Count; i++)
                {
                    item = top.Element;
                    top = top.Previos;
                    count--;
                }
            }
        }

        /// <summary>
        /// Determines whether an element is in the stack
        /// </summary>
        /// <returns> true if item is found in the stack, otherwise returns false. </returns>
        public bool Contains(object item)
        {
            bool found = false;

            Node currentNode = this.top;
            for (int i = 0; i < this.Count; i++)
            {
                if (item == currentNode.Element)
                {
                    found = true;
                    break;
                }
                currentNode = currentNode.Previos;
            }
            return found;
        }

        /// <summary>
        /// Returns a new array containing copies of the elements of the stack
        /// </summary>
        public object[] ToArray()
        {
            object[] stackArray = new object[count];
            if (top != null)
            {
                Node currentNode = this.top;

                for (int i = 0; i < this.Count; i++)
                {
                    stackArray[i] = currentNode.Element;
                    currentNode = currentNode.Previos;
                }
            }
            return stackArray;
        }

        /// <summary>
        /// Gets the number of elements in the list
        /// </summary>
        public int Count
        {
            get{ return count; }
        }
    }
}
