﻿using System;
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

        public void InsertAfter(int existingItem, int newItem)
        {
            int index = IndexOf(existingItem);
            if (index != -1)
            {
                ShiftRight(index);
                backingArray[index] = newItem;
            }
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
            throw new NotImplementedException();
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

        // TODO
        private void Resize()
        {

        }
    }
}
