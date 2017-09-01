namespace Generic
{
    using System;
    public class GenericList<T> where T : IComparable<T>
    {
        private const int InitialCapacity = 5; // fixed capacity
        private int capacity;
        private int count;

        private T[] elements; // list of elements of some parametric type T

        #region Constructors

        public GenericList()
        {
            this.Capacity = InitialCapacity; // fixed capacity is given as parameter in the class constructor.
            this.elements = new T[InitialCapacity];
        }

        #endregion

        #region Properties

        public int Capacity { get; set; }
        public int Count { get; set; }

        #endregion

        #region Methodes for Pr.5 - Add, IndexOf, RemoveAtIndex, AddAtIndex, Clear, AccessByIndex

        public void Add(T element)
        {
            if (this.Count == this.Capacity)

            {
                this.AutoGrow();
            }

            this.elements[this.Count] = element;
            this.Count++;

        }

        public int IndexOf(T value)
        {
            int valueIndex = -1;

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (value.ToString() == this.elements[i].ToString())
                {
                    valueIndex = i;
                    break;
                }
            }
            return valueIndex;
        }

        public void RemoveAtIndex(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
            }

            for (int i = index; i < this.Count - 1; i++) // the elements that we want to remove is equal to the next element int the array etc..
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.Count--; // finally we decrease the Count with 1
        }

        public void AddAtIndex(int index, T newElement)
        {
            if (index >= this.Capacity || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
            }

            var temp = new GenericList<T>();

            for (int i = index; i < this.Count; i++)
            {
                temp.Add(this.elements[i]);
            }

            this.elements[index] = newElement;

            for (int i = 0, j = index + 1; i <= temp.Count; i++, j++)
            {
                this.elements[j] = temp.elements[i];
            }

            this.Count++;
        }

        public void Clear()
        {
            this.elements = new T[InitialCapacity];
            this.Capacity = InitialCapacity;
            this.Count = 0;
        }

        public T AccessByIndex(int index)
        {
            T element = elements[index];
            return element;
        }

        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 0; i < this.Count; i++)
            {
                result += this.elements[i];

                if (i < this.Count - 1)
                {
                    result += ", "; // to escape last comma
                }
            }
            return result;
        }
        /*
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var item in this.elements)
            {
                builder.Append(item).Append("\r\n");
            }

            return builder.ToString();
        }
        */


        #endregion

        #region Methode for Pr.6 - AutoGrow
        public void AutoGrow() //when the internal array is full, create a new array of double size and move all elements to it.
        {
            var oldElements = this.elements;

            this.Capacity *= 2;
            this.elements = new T[Capacity];
            Array.Copy(oldElements, this.elements, this.Count);
        }
        #endregion

        #region Methodes for Pr.7 - Min and Max

        public T Min()
        {
            if ((this.Count) < 0)
            {
                throw new ArgumentException("The list is empty, no elements found.");
            }

            T min = this.elements[0]; // we are taking as minimal val the first element

            foreach (T item in this.elements)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public T Max()
        {
            if ((this.Count) < 0)
            {
                throw new ArgumentException("The list is empty, no elements found.");
            }

            T max = this.elements[0]; // we are taking as maximal val the first element

            foreach (T item in this.elements)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }


        #endregion

    }
}
