using System;

namespace LinearDataStructures
{
    public class DynamicStack<T>
    {
        private const int DefaultSize = 3;

        private int currentIndex;
        private T[] elements;

        public DynamicStack()
        {
            this.elements = new T[DefaultSize];
        }

        public void Push(T elementToPush)
        {
             
            this.elements[this.currentIndex] = elementToPush;
            this.currentIndex++;
            
            if (this.elements.Length == this.currentIndex)
            {
                int newLen = this.elements.Length * 2;
                T[] newElements = new T[newLen];
                Array.Copy(this.elements, newElements, this.elements.Length);

                this.elements = newElements;
            }
        }

        public T Pop()
        {
            T elementToReturn = default(T);
            if (this.currentIndex != 0)
            {
                this.currentIndex--;
                elementToReturn = this.elements[this.currentIndex];

            }

            return elementToReturn;
        }

        public T Peek()
        {
            return this.elements[this.currentIndex - 1];
        }
    }
}
