using System;
namespace ArrayList
{
    public class ArrayList: IList
    {
        private int[] backingArray;
        private int count = 0;

        public ArrayList(int capacity = 128)
        {
            backingArray = new int[capacity];
        }

        public int Length => count;

        public bool IsEmpty => (count == 0);

        public void Append(int item)
        {
            if(count==backingArray.Length)
            {
                Resize();
            }

            backingArray[count] = item;
            count++;
        }

        public int this[int index]
        {
            get
            {
                if( index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                return backingArray[index];
            }

            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                backingArray[index] = value;
            }
        }

        public bool Contains(int item)
        {
            foreach(var thing in backingArray)
            {
                if(thing == item)
                {
                    return true;
                }
            }

            return false;
        }

        /***
         * Returns true if existing element was found in the arrayList;
         * otherwise, returns false.
         */
        public bool InsertAfter(int existingItem, int newItem)
        {
            int index = IndexOf(existingItem);
            
            if (index != -1)
            {
                ShiftRight(index);
                backingArray[index] = newItem;
                count++;
            }

            return (index != -1);
        }

        public void Prepend(int item)
        {
            if (count == backingArray.Length)
            {
                Resize();
            }

            ShiftRight(0);
            backingArray[0] = item;
            count++;
        }

        // TODO
        public void Remove(int item)
        {
            throw new NotImplementedException();
        }

        // TODO
        public IList Reverse()
        {
            IList reversed = new ArrayList();
            
            // do the work;

            return reversed;

            //throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            for(int i=0; i< count; i++)
            {
                if( backingArray[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        private void ShiftRight(int startingIndex)
        {
            if( startingIndex == backingArray.Length)
            {
                // Resize()
            }

            for(int i = count; i > startingIndex; i--)
            {
                backingArray[i] = backingArray[i - 1];
            }
        }

        private void ShiftLeft(int startingIndex)
        {
            if(startingIndex < 1)
            {
                return;
            }

            for(int i=startingIndex; i < count; i++)
            {
                backingArray[i - 1] = backingArray[i];
            }
        }

        private void Resize()
        {
            Array.Resize<int>(ref backingArray, backingArray.Length * 2);
        }
    }
}
